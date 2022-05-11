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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            if (vehiculeCourant != null)
            {
                // fait la modification
                MessageBox.Show("Modification du véhicule effectué avec succès!");
                Close();
            }
            else
            {
                // fait l'ajout
                MessageBox.Show("Ajout du véhicule effectué avec succès!");
                Close();
            }
        }
    }
}
