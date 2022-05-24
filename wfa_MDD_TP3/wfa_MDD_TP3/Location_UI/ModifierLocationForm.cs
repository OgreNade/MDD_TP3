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
    public partial class ModifierLocationForm : Form
    {
        SystemeDeLocation systemedelocation;
        SystemeDeVehicule systemedeVehicule;
        ClientManager clientmanager;
        int noLocation;
        Location location;
        Client client;
        Vehicule vehicule;
        public ModifierLocationForm(SystemeDeLocation systemeDeLocation, SystemeDeVehicule systemeDeVehicule, ClientManager clientManager, int noLocation)
        {
            InitializeComponent();
            this.systemedelocation = systemeDeLocation;
            this.systemedeVehicule = systemeDeVehicule;
            this.clientmanager = clientManager;
            this.noLocation = noLocation;
        }

        private void ModifierLocationForm_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nom.Enabled = false;
            txt_prenom.Enabled = false;
            txt_serie.Enabled = false;
            txt_marque.Enabled = false;
            txt_modele.Enabled = false;
            txt_annee.Enabled = false;
            cmbMethodePaiment.Items.Add("Kilometrage");
            cmbMethodePaiment.Items.Add("Temps");
            location = systemedelocation.GetLocationByNoLocation(noLocation);
            client = clientmanager.GetClientParId(location.IdClient);
            vehicule = systemedeVehicule.GetVehiculeByNoSerie(location.NoSerie);
            txt_id.Text = client.IdClient.ToString();
            txt_nom.Text = client.Nom;
            txt_prenom.Text = client.Prenom;
            DTPStart.Value = location.DateStart;
            DTPEnd.Value = location.DateEnd;
            txt_serie.Text = vehicule.NoSerie;
            txt_marque.Text = vehicule.Marque;
            txt_modele.Text = vehicule.Modele;
            txt_annee.Text = vehicule.Annee.ToString();
            cmbMethodePaiment.SelectedItem = location.MethodePaiment;
            txtTotalPayer.Text = location.MontantPayer.ToString();
            dgvInspectionAvant.DataSource = location.InspectionsStart.ToList();
            dgvInspectionApres.DataSource = location.InspectionsEnd.ToList();
            dgvInspectionAvant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInspectionApres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVoiture.Visible = false;
            dgvVoiture.DataSource = systemedeVehicule.GetAllVehicules().ToList();
            dgvVoiture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtTotal.Enabled = false;
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            txtInspectionCarPartAvant.Visible = false;
            txtInspectionDescriptionAvant.Visible = false;
            txtInspectionCarPartApres.Visible = false;
            txtInspectionDescriptionApres.Visible = false;
            btnAddInspectionAvant.Visible = false;
            btnAddInspectionApres.Visible = false;
            dgvInspectionAvant.Enabled = true;
            dgvInspectionApres.Enabled = true;
            btnEnregistrer.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvVoiture.Visible = true;
            label6.Text = "Vehicule disponible:";
        }

        private void dgvVoiture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicule = systemedeVehicule.GetVehiculeByNoSerie(dgvVoiture[0, dgvVoiture.CurrentRow.Index].Value.ToString());
            txt_serie.Text = vehicule.NoSerie;
            txt_marque.Text = vehicule.Marque;
            txt_modele.Text = vehicule.Modele;
            txt_annee.Text = vehicule.Annee.ToString();
            dgvVoiture.Visible = false;
            label6.Text = "Inspection avant la location";
        }

        private void btnAjouterInspectionAvant_Click(object sender, EventArgs e)
        {
            dgvInspectionApres.Visible = false;
            btnAjouterInspectionAvant.Visible = false;
            btnAjouterInspectionApres.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            txtInspectionCarPartAvant.Visible = true;
            txtInspectionDescriptionAvant.Visible = true;
            btnAddInspectionAvant.Visible = true;
        }

        private void btnAjouterInspectionApres_Click(object sender, EventArgs e)
        {
            dgvInspectionAvant.Visible = false;
            btnAjouterInspectionAvant.Visible = false;
            btnAjouterInspectionApres.Visible = false;
            label8.Visible = true;
            label9.Visible = true;
            txtInspectionCarPartApres.Visible = true;
            txtInspectionDescriptionApres.Visible = true;
            btnAddInspectionApres.Visible = true;
        }

        private void dgvInspectionAvant_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            location.ModifierInspectionStart(Convert.ToInt32(dgvInspectionAvant[0, dgvInspectionAvant.CurrentRow.Index].Value), dgvInspectionAvant[2, dgvInspectionAvant.CurrentRow.Index].Value.ToString());
            afficheDgvInspections();
        }

        private void dgvInspectionApres_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            location.ModifierInspectionEnd(Convert.ToInt32(dgvInspectionApres[0, dgvInspectionApres.CurrentRow.Index].Value), dgvInspectionApres[2, dgvInspectionApres.CurrentRow.Index].Value.ToString());
            afficheDgvInspections();
        }

        private void btnAddInspectionApres_Click(object sender, EventArgs e)
        {
            location.AddInspectionEnd(txtInspectionCarPartApres.Text, txtInspectionDescriptionApres.Text);
            afficheDgvInspections();
            dgvInspectionAvant.Visible = true;
            btnAjouterInspectionAvant.Visible = true;
            btnAjouterInspectionApres.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            txtInspectionCarPartApres.Visible = false;
            txtInspectionDescriptionApres.Visible = false;
            btnAddInspectionApres.Visible = false;
        }

        private void btnAddInspectionAvant_Click(object sender, EventArgs e)
        {
            location.AddInspectionStart(txtInspectionCarPartAvant.Text, txtInspectionCarPartAvant.Text);
            afficheDgvInspections();
            dgvInspectionApres.Visible = true;
            btnAjouterInspectionAvant.Visible = true;
            btnAjouterInspectionApres.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            txtInspectionCarPartAvant.Visible = false;
            txtInspectionDescriptionAvant.Visible = false;
            btnAddInspectionAvant.Visible = false;
        }
        public void afficheDgvInspections()
        {
            dgvInspectionAvant.DataSource = location.InspectionsStart.ToList();
            dgvInspectionApres.DataSource = location.InspectionsEnd.ToList();
            dgvInspectionAvant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInspectionApres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMethodePaiment.SelectedItem.ToString() == "Kilometrage" && txt_km.Text != "")
            {
                txtTotal.Text = (vehicule.Prix * (Convert.ToDouble(txt_km.Text) - location.KilometrageStart)).ToString();
            }
            else if (cmbMethodePaiment.SelectedItem.ToString() == "Temps")
            {
                txtTotal.Text = (vehicule.Prix * Convert.ToDouble(DTPEnd.Value.Day - location.DateStart.Day)).ToString();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une methode de paiment et soit le kilometrage ou la date de retour pour calculer le total");
            }
            btnEnregistrer.Enabled = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sure de vouloir enregistrer les changements apporter a la location?", "Location prestige", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                systemedelocation.ModifierLocation(new Location(location.NoLocation, location.DateStart, location.DateEnd, client.IdClient, vehicule.NoSerie, location.KilometrageStart, int.Parse(txt_km.Text), location.Etat, location.InspectionsStart, location.InspectionsEnd, cmbMethodePaiment.SelectedItem.ToString(), Convert.ToDouble(txtTotal.Text), Convert.ToDouble(txtTotalPayer.Text)));
            }
        }
    }
}
