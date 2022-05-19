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
    public partial class GestionVehiculeForm : Form
    {
        SystemeDeVehicule systemeDeVehicule;
        public GestionVehiculeForm(SystemeDeVehicule systemeDeVehicule)
        {
            InitializeComponent();
            this.systemeDeVehicule = systemeDeVehicule;
        }

        private void btnAjouterVehicule_Click(object sender, EventArgs e)
        {
            InfoVehiculeForm infoVehiculeForm = new InfoVehiculeForm(systemeDeVehicule);
            infoVehiculeForm.ShowDialog();

            AfficheVehicule(txtFiltre.Text);
        }

        private void btnModifierVehicule_Click(object sender, EventArgs e)
        {
            string noSerie = DGV.SelectedRows[0].Cells[0].Value.ToString();

            InfoVehiculeForm infoVehiculeForm = new InfoVehiculeForm(systemeDeVehicule,noSerie);
            infoVehiculeForm.ShowDialog();

            AfficheVehicule(txtFiltre.Text);
        }

        private void btnRevenirAuMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionVehiculeForm_Load(object sender, EventArgs e)
        {
            AfficheVehicule("");
        }

        private void AfficheVehicule(string filtre)
        {
            DGV.DataSource = null;
            filtre = filtre.ToLower();

            if (filtre == "")
            {
                DGV.DataSource = systemeDeVehicule.GetAllVehicules();
            }
            else
            {
                IList<Vehicule> vehiculesFiltre = new List<Vehicule>();

                foreach (var vehicule in systemeDeVehicule.GetAllVehicules())
                {
                    if (vehicule.NoSerie.ToLower().Contains(filtre) || 
                        vehicule.Marque.ToLower().Contains(filtre)  || 
                        vehicule.Modele.ToLower().Contains(filtre)  ||
                        vehicule.Annee.ToString().Contains(filtre)  ||
                        vehicule.Couleur.ToLower().Contains(filtre) ||
                        vehicule.EtatCourent.ToString().ToLower().Contains(filtre) )
                    {
                        vehiculesFiltre.Add(vehicule);
                    }
                }

                DGV.DataSource = vehiculesFiltre;
            }

            DGV.ClearSelection();
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnModifierVehicule.Enabled = false;
            btnSupprimerVehicule.Enabled = false;
        }

        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            AfficheVehicule(txtFiltre.Text);
        }

        private void btnSupprimerVehicule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer le vehicule sélectionné?", "AVERTISSEMENT",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string noSerie = DGV.SelectedRows[0].Cells[0].Value.ToString();

                if (systemeDeVehicule.SupprimerVehicule(noSerie))
                {
                    MessageBox.Show("Le vehicule a bien été supprimé");
                    AfficheVehicule(txtFiltre.Text);
                }
            }
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            btnModifierVehicule.Enabled = true;
            btnSupprimerVehicule.Enabled = true;
        }
    }
}
