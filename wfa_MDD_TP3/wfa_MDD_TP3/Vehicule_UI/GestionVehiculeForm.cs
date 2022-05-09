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
            InfoVehiculeForm infoVehiculeForm = new InfoVehiculeForm(false);
            infoVehiculeForm.ShowDialog();
        }

        private void btnModifierVehicule_Click(object sender, EventArgs e)
        {
            InfoVehiculeForm infoVehiculeForm = new InfoVehiculeForm(true);
            infoVehiculeForm.ShowDialog();
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
        }

        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            AfficheVehicule(txtFiltre.Text);
        }
    }
}
