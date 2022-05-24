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
    public partial class AjouterLocationForm : Form
    {
        SystemeDeLocation systemeDeLocation;
        SystemeDeVehicule systemeDeVehicule;
        ClientManager clientManager;
        public AjouterLocationForm(SystemeDeLocation systemeDeLocation, SystemeDeVehicule systemeDeVehicule, ClientManager clientManager)
        {
            InitializeComponent();
            this.systemeDeLocation = systemeDeLocation;
            this.systemeDeVehicule = systemeDeVehicule;
            this.clientManager = clientManager;
        }

        private void LocationInterface_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            lbl_prenom.Visible = false;
            txt_prenom.Visible = false;
            txt_serie.Enabled = false;
            txt_marque.Enabled = false;
            txt_modele.Enabled = false;
            txt_annee.Enabled = false;
            comboBox1.Items.Add("Kilometrage");
            comboBox1.Items.Add("Temps");
            btn_creerReservation.Enabled = false;
            txt_km.Enabled = false;
            btnChercheClient.Enabled = false;
            btnChercheVoiture.Enabled = false;
            dtpDateEnd.Enabled = false;
            txt_nom.Enabled = false;
        }

        private void btnChercheClient_Click(object sender, EventArgs e)
        {
            DGVClient.DataSource = null;
            List<Client> clients = new List<Client>();
            if (txt_nom.Text != "")
            {
                foreach (var client in clientManager.GetAllClients())
                {
                    if ((client.Prenom.ToLower() +" " + client.Nom.ToLower()).Contains(txt_nom.Text.ToLower()))
                    {
                        clients.Add(client);
                    }
                }
            }
            DGVClient.DataSource = clients;
            DGVClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label6.Text = "Sélectionner un client!!";
        }

        private void DGVClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Convert.ToString(DGVClient[0, DGVClient.CurrentRow.Index].Value);
            lbl_prenom.Visible = true;
            txt_prenom.Visible = true;
            lbl_nom.Text = "Nom:";
            txt_nom.Text = Convert.ToString(DGVClient[2, DGVClient.CurrentRow.Index].Value);
            txt_prenom.Text = Convert.ToString(DGVClient[3, DGVClient.CurrentRow.Index].Value);
            txt_nom.Enabled = false;
            txt_prenom.Enabled = false;
            btnChercheClient.Visible = false;
            label6.Text = "Réservation antécédante du client";
            AfficheLocationClient();
            DGVClient.Enabled = false;
            DGVVoiture.DataSource = systemeDeVehicule.GetAllVehicules();
            btnChercheVoiture.Enabled = true;
        }
        public void AfficheLocationClient()
        {
            DGVClient.DataSource = null;
            IList<Location> locationsFiltre = new List<Location>();
            foreach (var location in systemeDeLocation.GetAllLocations())
            {
                if (location.IdClient == int.Parse(txt_id.Text))
                {
                    locationsFiltre.Add(location);
                }
            }
            if (locationsFiltre == null)
            {
                MessageBox.Show("Le client sélectionné n'a jamais fait de location");
            }
            DGVClient.DataSource = locationsFiltre;
        }
        private void btnChercheVoiture_Click(object sender, EventArgs e)
        {
            Vehicule vehicule = systemeDeVehicule.GetVehiculeByNoSerie(Convert.ToString(DGVVoiture[0, DGVVoiture.CurrentRow.Index].Value));
            txt_serie.Text = vehicule.NoSerie;
            txt_marque.Text = vehicule.Marque;
            txt_modele.Text = vehicule.Modele;
            txt_annee.Text = vehicule.Annee.ToString();
            btnChercheVoiture.Visible = false;
            DGVVoiture.Enabled = false;
        }

        private void txt_km_TextChanged(object sender, EventArgs e)
        {
            btn_creerReservation.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_km.Enabled = true;
        }

        private void btn_creerReservation_Click(object sender, EventArgs e)
        {
            int noLocation = systemeDeLocation.GetAllLocations().Last().NoLocation + 1;
            DateTime dateStart = dtpDateStart.Value;
            DateTime dateEnd = dtpDateEnd.Value;
            int idClient = int.Parse(txt_id.Text);
            string noSerie = txt_serie.Text;
            int kilometrageStart = systemeDeVehicule.GetVehiculeByNoSerie(txt_serie.Text).Kilometrage;
            wfa_MDD_TP3.Location_Logic.Etat etat = wfa_MDD_TP3.Location_Logic.Etat.Location;
            Inspection inspection = new Inspection(0, "test", "test");
            List<Inspection> inspections = new List<Inspection>();
            inspections.Add(inspection);
            string methodePaiment = comboBox1.SelectedItem.ToString();
            double montantPaye = Convert.ToDouble(txt_km.Text);
            Location location = new Location(noLocation, dateStart, dateEnd, idClient, noSerie, kilometrageStart, kilometrageStart, etat, inspections, inspections, methodePaiment, 0, montantPaye);
            systemeDeLocation.AjouterLocation(location);
            MessageBox.Show("La location à été enregistrer dans la base de données");
            AfficheLocationClient();
            this.Close();
        }

        private void btnAnnulerLocation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous annuler toute les informations entrer pour l'ajout d'une location", "Location prestige", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AjouterLocationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            dtpDateEnd.Enabled = true;
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            txt_nom.Enabled = true;
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            btnChercheClient.Enabled = true;
        }
    }
}
