using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfa_MDD_TP3.Vehicule_Logic;

namespace wfa_MDD_TP3
{
    public partial class InfoVehiculeForm : Form
    {
        SystemeDeVehicule systemeDeVehicule;
        Vehicule vehiculeCourant;

        public InfoVehiculeForm(SystemeDeVehicule systemeDeVehicule,string noSerie)
        {
            InitializeComponent();

            this.systemeDeVehicule = systemeDeVehicule;
            vehiculeCourant = systemeDeVehicule.GetVehiculeByNoSerie(noSerie);
        }

        public InfoVehiculeForm(SystemeDeVehicule systemeDeVehicule)
        {
            InitializeComponent();

            this.systemeDeVehicule = systemeDeVehicule;
            vehiculeCourant = null;
        }

        private void InfoVehiculeForm_Load(object sender, EventArgs e)
        {
            RemplirComboBox();

            if (vehiculeCourant != null)
            {
                // mode modification
                grbInfoPermanente.Enabled = false;
                btnConfirmation.Text = "Modifier";

                txtNoSerie.Text = vehiculeCourant.NoSerie;
                cmbMarque.SelectedItem = vehiculeCourant.Marque;
                cmbModele.SelectedItem = vehiculeCourant.Modele;
                txtAnnee.Text = vehiculeCourant.Annee.ToString();

                nudPrix.Value = (decimal)vehiculeCourant.Prix;
                cmbCouleur.SelectedItem = vehiculeCourant.Couleur;
                nudKilometrage.Value = vehiculeCourant.Kilometrage;
                cmbEtat.SelectedItem = vehiculeCourant.EtatCourent;
            }
            else
            {
                // mode ajout
                btnConfirmation.Text = "Ajouter";
            }
        }

        private void RemplirComboBox()
        {
            // remplir comboBox pour les marques :
            cmbMarque.Items.Add("Ford");

            // remplir comboBox pour les modeles :
            // (normalement changerait selon la marque choisi)
            cmbModele.Items.Add("Mustang");
            cmbModele.Items.Add("Escape");

            // remplir comboBox pour les couleurs :
            // (normalement changerait selon le modele choisi)
            cmbCouleur.Items.Add("Rouge");
            cmbCouleur.Items.Add("Bleu");
            cmbCouleur.Items.Add("Noir");
            cmbCouleur.Items.Add("Jaune");

            // remplir comboBox pour les Etat possibles :
            RemplirComboBoxEtat();
        }

        private void RemplirComboBoxEtat()
        {
            cmbEtat.Items.Add(Etat.Disponible);
            cmbEtat.Items.Add(Etat.Endomage);
            cmbEtat.Items.Add(Etat.Inspection);
            cmbEtat.Items.Add(Etat.Loue);
            cmbEtat.Items.Add(Etat.Reparation);
            cmbEtat.Items.Add(Etat.Scrap);
            cmbEtat.Items.Add(Etat.Vendu);
        }

        private void VerifierInput()
        {
            if (txtNoSerie.Text == "")
                throw new Exception("Veuillez entrer un numero de serie pour le vehicule");

            if (cmbMarque.SelectedItem == null)
                throw new Exception("Veuillez selectionner une marque pour le vehicule");

            if (cmbModele.SelectedItem == null)
                throw new Exception("Veuillez selectionner un modele pour le vehicule");

            if (!int.TryParse(txtAnnee.Text, out int anneDuVehicule))
                throw new Exception("L'année doit être un entier");

            if (nudPrix.Value == 0)
                throw new Exception("Veuillez selectionner un prix pour le vehicule");

            if (cmbCouleur.SelectedItem == null)
                throw new Exception("Veuillez selectionner une couleur pour le vehicule");

            if (cmbEtat.SelectedItem == null)
                throw new Exception("Veuillez selectionner un Etat pour le vehicule");
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            try
            {
                VerifierInput();

                if (vehiculeCourant != null)
                {
                    systemeDeVehicule.GetVehiculeByNoSerie(txtNoSerie.Text).ModifierVehicule(
                        (double)nudPrix.Value,
                        cmbCouleur.SelectedItem.ToString(),
                        (int)nudKilometrage.Value,
                        (Etat)cmbEtat.SelectedItem);

                    MessageBox.Show("Modification du véhicule effectué avec succès!");
                    Close();
                }
                else
                {
                    vehiculeCourant = new Voiture(
                        txtNoSerie.Text,
                        cmbMarque.SelectedItem.ToString(),
                        cmbModele.SelectedItem.ToString(),
                        int.Parse(txtAnnee.Text),
                        (double)nudPrix.Value,
                        cmbCouleur.SelectedItem.ToString(),
                        (int)nudKilometrage.Value,
                        (Etat)cmbEtat.SelectedItem);

                    systemeDeVehicule.AjouterVehicule(vehiculeCourant);

                    MessageBox.Show("Ajout du véhicule effectué avec succès!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
