using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfa_MDD_TP3.Location_Logic;
using wfa_MDD_TP3.Client_Logic;
using wfa_MDD_TP3.Vehicule_Logic;

namespace wfa_MDD_TP3.Location_UI
{
    public partial class GestionLocationForm : Form
    {
        SystemeDeLocation systemeDeLocation;
        ClientManager clientManager;
        SystemeDeVehicule systemeDeVehicule;
        public GestionLocationForm(SystemeDeLocation systemeDeLocation, ClientManager clientManager, SystemeDeVehicule systemeDeVehicule)
        {
            InitializeComponent();
            this.systemeDeLocation = systemeDeLocation;
            this.clientManager = clientManager;
            this.systemeDeVehicule = systemeDeVehicule;
        }

        private void GestionLocationForm_Load(object sender, EventArgs e)
        {
            AfficheLocations("");
            btnModifierLocation.Enabled = false;
            btnSupprimerLocation.Enabled = false;
        }
        private void AfficheLocations(string filtre)
        {
            dataGridView1.DataSource = null;
            filtre = filtre.ToLower();

            if (filtre == "")
            {
                dataGridView1.DataSource = systemeDeLocation.GetFutureLocations();
            }
            else
            {
                int IdClient = -1;
                for (int i = 0; i < clientManager.GetAllClients().Count; i++)
                {
                    if ((clientManager.GetAllClients()[i].Prenom.ToLower()+ " " + clientManager.GetAllClients()[i].Nom.ToLower()).Contains(filtre))
                    {
                        IdClient = clientManager.GetAllClients()[i].IdClient;
                    }
                }
                IList<Location> locationsFiltre = new List<Location>();
                foreach(var location in systemeDeLocation.GetFutureLocations())
                {
                    if (location.IdClient == IdClient)
                    {
                        locationsFiltre.Add(location);
                    }
                }
                dataGridView1.DataSource = locationsFiltre;
            }
            dataGridView1.ClearSelection();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRechercheLocation_Click(object sender, EventArgs e)
        {
            AfficheLocations(textBox1.Text);
        }

        private void btnAfficherTouteLocation_Click(object sender, EventArgs e)
        {
            AfficherAllLocationForm afficherAllLocationForm = new AfficherAllLocationForm(systemeDeLocation, clientManager);
            afficherAllLocationForm.ShowDialog();
        }

        private void btnAjouterLocation_Click(object sender, EventArgs e)
        {
            AjouterLocationForm ajouterLocationForm = new AjouterLocationForm(systemeDeLocation, systemeDeVehicule, clientManager);
            ajouterLocationForm.ShowDialog();
            AfficheLocations("");
        }

        private void btnModifierLocation_Click(object sender, EventArgs e)
        {
            int noLocation = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            ModifierLocationForm modifierLocationForm = new ModifierLocationForm(systemeDeLocation, systemeDeVehicule, clientManager, noLocation);
            modifierLocationForm.ShowDialog();
            AfficheLocations("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifierLocation.Enabled = true;
            btnSupprimerLocation.Enabled = true;
        }

        private void btnSupprimerLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer cette location?", "Location prestige", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                systemeDeLocation.SupprimerLocation(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
                AfficheLocations("");
            }
        }
    }
}
