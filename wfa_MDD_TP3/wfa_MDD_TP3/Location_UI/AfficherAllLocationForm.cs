using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfa_MDD_TP3.Client_Logic;
using wfa_MDD_TP3.Location_Logic;
using wfa_MDD_TP3.Vehicule_Logic;

namespace wfa_MDD_TP3.Location_UI
{
    public partial class AfficherAllLocationForm : Form
    {
        SystemeDeLocation systemeDeLocation;
        ClientManager clientManager;
        public AfficherAllLocationForm(SystemeDeLocation systemeDeLocation, ClientManager clientManager)
        {
            InitializeComponent();
            this.systemeDeLocation = systemeDeLocation;
            this.clientManager = clientManager;
        }

        private void AfficherAllLocationForm_Load(object sender, EventArgs e)
        {
            AfficheLocations("");
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
                    if ((clientManager.GetAllClients()[i].Prenom.ToLower() + " " + clientManager.GetAllClients()[i].Nom.ToLower()).Contains(filtre))
                    {
                        IdClient = clientManager.GetAllClients()[i].IdClient;
                    }
                }
                IList<Location> locationsFiltre = new List<Location>();
                foreach (var location in systemeDeLocation.GetFutureLocations())
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

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            AfficheLocations(textBox1.Text);
        }
    }
}
