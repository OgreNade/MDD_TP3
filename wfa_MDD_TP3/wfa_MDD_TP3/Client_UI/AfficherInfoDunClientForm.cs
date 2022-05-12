using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace wfa_MDD_TP3.Client_Logic
{
    public partial class AfficherInfoDunClientForm : Form
    {
        public AfficherInfoDunClientForm(Client client)
        {
            InitializeComponent();
            RemplirCmb();
            AfficherInfoClient(client);
            ToggleField(false);
        }
        private void ToggleField(bool etat)
        {
            txtNoPermitConduire.Enabled = etat;
            txtDateCreationDossier.Enabled = etat;
            txtNom.Enabled = etat;
            txtPrenom.Enabled = etat;
            dtpDateDeNaissance.Enabled = etat;
            cmbGenre.Enabled = etat;
            txtTelephone.Enabled = etat;
            txtCellulaire.Enabled = etat;
            txtCourriel.Enabled = etat;
            cmbStatue.Enabled = etat;
            txtDateCreationDossier.Enabled = etat;
            txtCreerPar.Enabled = etat;
        }

        private void AfficherInfoClient(Client client)
        {
            txtNoPermitConduire.Text = client.NoPermitConduire;
            txtNom.Text = client.Nom;
            txtPrenom.Text = client.Prenom;
            if (client.IdClient > 8)
            {
                dtpDateDeNaissance.Value = client.DateDeNaissance;
            }
            else
            {
                dtpDateDeNaissance.Value = DateTime.ParseExact(client.DateNaissanceHC, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            cmbGenre.SelectedItem = client.Genre;
            txtTelephone.Text = client.Telephone;
            txtCellulaire.Text = client.Cellulaire;
            txtCourriel.Text = client.Courriel;
            cmbStatue.SelectedItem = client.Statue;
            txtDateCreationDossier.Text = client.DateCreation;
            txtCreerPar.Text = client.CreerPar;
        }
        private void RemplirCmb()
        {
            cmbGenre.Items.Add("Homme");
            cmbGenre.Items.Add("Femme");
            cmbStatue.Items.Add("Actif");
            cmbStatue.Items.Add("Inactif");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette option sera disponible sous peu.");
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
