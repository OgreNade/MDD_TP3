using System;
using System.Windows.Forms;

namespace wfa_MDD_TP3.Client_Logic
{
    public partial class AjouterClientForm : Form
    {
        ClientManager ClientManager;

        public AjouterClientForm(ClientManager clientManager)
        {
            InitializeComponent();
            this.ClientManager = clientManager;
        }
        private void RemplirCmb()
        {
            cmbGenre.Items.Add("Homme");
            cmbGenre.Items.Add("Femme");
            cmbStatue.Items.Add("Actif");
            cmbStatue.Items.Add("Inactif");
        }

        private void VerifierChampRemplie()
        {
            if (txtNoPermitConduire.Text == "" || txtNom.Text == "" || txtPrenom.Text == "" || txtTelephone.Text == "" || txtCellulaire.Text == "" || txtCourriel.Text == "" || cmbGenre.SelectedItem == null || cmbStatue.SelectedItem == null)
            {
                throw new Exception("Vous devez remplir les champs avant de sauvegarder.");
            }
            if (dtpDateDeNaissance.Value.Date == DateTime.Now.Date)
            {
                throw new Exception("Je doute que ce client soit né aujourd'hui");
            }
        }
        private void SauvegarderClient()
        {
            try
            {
                VerifierChampRemplie();
                VerifierSiClientMajeur();
                if (MessageBox.Show("Êtes vous sûr de vouloir sauvergarder?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    AjouterClient();
                }
                else

                {
                    MessageBox.Show("Enregistrement annulée");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VerifierSiClientMajeur()
        {
            var today = DateTime.Today;
            var BirthDate = dtpDateDeNaissance.Value.Date;
            var age = today.Year - dtpDateDeNaissance.Value.Year;
            if (BirthDate > today.AddYears(-age) || age == 0)
            {
                throw new Exception("Le client doit être majeur");
            }
        }

        private void AjouterClient()
        {
            ClientManager.AjouterClient(new Client(ClientManager.NouveauId, txtNoPermitConduire.Text, txtNom.Text, txtPrenom.Text, dtpDateDeNaissance.Value, cmbGenre.SelectedItem.ToString(), txtTelephone.Text, txtCellulaire.Text, txtCourriel.Text, cmbStatue.SelectedItem.ToString(), txtDateCreationDossier.Text, txtCreerPar.Text));
            MessageBox.Show("Enregistrement effectuer avec succès!");
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes vous sûr de vouloir annuler l'ajout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                MessageBox.Show("Nouvelle enregistrement annuler.");
                Close();
            }

            else

            {

            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            SauvegarderClient();
        }

        private void AjouterClientForm_Load(object sender, EventArgs e)
        {
            RemplirCmb();
            txtDateCreationDossier.Text = DateTime.Now.ToShortDateString();
        }
    }
}
