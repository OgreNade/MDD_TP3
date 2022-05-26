using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfa_MDD_TP3.Connexion_Logic;

namespace wfa_MDD_TP3
{
    public partial class Connexion : Form
    {
        SystemeGeneral SystemeGeneral;
        public Connexion(SystemeGeneral systemeGeneral)
        {
            InitializeComponent();
            this.SystemeGeneral = systemeGeneral;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            bool isConnected = false;
            foreach (Employee utilisateur in SystemeGeneral.utilisateurManager.GetAllUtilisateur())
            {
                if (utilisateur.EmailUtilisateur == txtEmail.Text && utilisateur.MDP_Utilisateur == txtMDP.Text)
                {
                    MainForm mainForm = new MainForm(SystemeGeneral, utilisateur);
                    mainForm.ShowDialog();
                    isConnected = true;
                    Close();
                } 
            }
            if (!isConnected)
            {
                MessageBox.Show("Email ou mot de passe invalide");
            }
           
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}