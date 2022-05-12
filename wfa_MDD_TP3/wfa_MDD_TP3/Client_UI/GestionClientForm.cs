using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wfa_MDD_TP3.Client_Logic
{
    public partial class GestionClientsFrm : Form
    {
        ClientManager ClientManager;
        public GestionClientsFrm()
        {
            InitializeComponent();
            RemplirDgvHardCoder();
            ClientManager = new ClientManager();
            btnRechercher.Enabled = false;
            RemplirCmbRecherchePar();
        }

        private void RemplirCmbRecherchePar()
        {
            cmbRecherchePar.Items.Add("Nom");
            cmbRecherchePar.Items.Add("Prénom");
            cmbRecherchePar.Items.Add("Date de naissance");
            cmbRecherchePar.Items.Add("Genre");
            cmbRecherchePar.Items.Add("Téléphone");
            cmbRecherchePar.Items.Add("Cellulaire");
            cmbRecherchePar.Items.Add("Statue");
        }

        

        public void RemplirDgvHardCoder()
        {
            dgvResultat.Columns.Add("IdClient", "Id");
            dgvResultat.Columns.Add("NoPermit", "No permit");
            dgvResultat.Columns.Add("Nom", "Nom");
            dgvResultat.Columns.Add("Prenom", "Prénom");
            dgvResultat.Columns.Add("DateDeNaissance", "Date de naissance");
            dgvResultat.Columns.Add("Genre", "Genre");
            dgvResultat.Columns.Add("Telephone", "Téléphone");
            dgvResultat.Columns.Add("Cellulaire", "Cellulaire");
            dgvResultat.Columns.Add("Courriel", "Courriel");
            dgvResultat.Columns.Add("Statue", "Statue");
            dgvResultat.Columns.Add("DateCreation", "Date création");
            dgvResultat.Columns.Add("CreerPar", "Créer par");
            dgvResultat.Rows.Add(1, "D9553-300493-99", "Dumas", "Rapphael", "27/04/1993", "Homme", "418-228-7456", "418-222-8882", "RaphLeChef@hotmail.com", "Actif", "27/05/2021", "Roger");
            dgvResultat.Rows.Add(2, "G8563-352390-50", "Girard", "Jean", "26/06/1990", "Homme", "418-228-5677", "418-221-6682", "GGirard773@outlook.com", "Actif", "22/07/2020", "Roger");
            dgvResultat.Rows.Add(3, "H5553-458585-11", "Hook", "Martine", "11/01/1985", "Femme", "418-685-8874", "418-957-5699", "HookMart8@gmail.com", "Actif", "28/03/2022", "Roger");
            dgvResultat.Rows.Add(4, "K1239-315495-85", "Keller", "Jino", "15/10/1995", "Homme", "418-774-5577", "418-974-7682", "KellerJino11@outlook.com", "Inactif", "20/09/2020", "Roger");
            dgvResultat.Rows.Add(5, "P9473-300488-99", "Pascal", "Élodie", "12/06/1988", "Femme", "418-227-1177", "418-226-8266", "EloPascal@outlook.com", "Actif", "17/11/2020", "Roger");
            dgvResultat.Rows.Add(6, "M9598-790475-14", "Martin", "Jacques", "22/08/1975", "Homme", "514-388-1119", "418-226-1017", "MartinJacques_entraineur@outlook.com", "Actif", "14/12/2021", "Roger");
            dgvResultat.Rows.Add(7, "M9553-770470-19", "Macabbé", "Chantal", "21/06/1970", "Femme", "418-227-9996", "418-221-8163", "PasLaVraiCM@outlook.com", "Actif", "01/04/2022", "Roger");
            dgvResultat.Rows.Add(8, "B9553-300469-95", "Bergevin", "Marc", "05/11/1969", "Homme", "418-228-1116", "418-974-6682", "BergMarc69@outlook.com", "Inactif", "16/07/2021", "Roger");
        }

       

        private void ClearDGV()
        {
            dgvResultat.Rows.Clear();
        }
        private void RafraichirDGV()
        {
            ClearDGV();
            foreach (var client in ClientManager.clients)
            {
                if (client.IdClient <= 8)
                {
                    dgvResultat.Rows.Add(client.IdClient, client.NoPermitConduire, client.Nom, client.Prenom, client.DateNaissanceHC, client.Genre, client.Telephone, client.Cellulaire, client.Courriel, client.Statue, client.DateCreation, client.CreerPar);
                }
                else
                {
                    dgvResultat.Rows.Add(client.IdClient, client.NoPermitConduire, client.Nom, client.Prenom, client.DateDeNaissance.ToShortDateString(), client.Genre, client.Telephone, client.Cellulaire, client.Courriel, client.Statue, client.DateCreation, client.CreerPar);
                }
                SettingDGV();
            }
        }

        private void SettingDGV()
        {
            dgvResultat.ClearSelection();
            dgvResultat.Columns[0].Visible = false;
        }
       

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterClientForm ajouterClientForm = new AjouterClientForm(ClientManager);
            ajouterClientForm.ShowDialog();
        }

        private void dgvResultat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idClient = Convert.ToInt32(dgvResultat.Rows[e.RowIndex].Cells[0].Value);
                AfficherInfoDunClientForm afficherInfoDunClientForm = new AfficherInfoDunClientForm(ClientManager.GetClientParId(idClient));
                afficherInfoDunClientForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void GestionClientsFrm_Load(object sender, EventArgs e)
        {
            SettingDGV();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette option sera disponible sous peu pour les administrateurs seulement");
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La recherche spécifique sera disponible sous peu");
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            RafraichirDGV();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                btnRechercher.Enabled = false;
            }
            else
            {
                btnRechercher.Enabled = true;
            }
        }
    }
}
