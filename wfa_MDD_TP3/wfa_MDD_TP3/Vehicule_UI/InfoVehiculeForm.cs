using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_MDD_TP3
{
    public partial class InfoVehiculeForm : Form
    {
        bool modeModification; // me permet d'utiliser la même form pour les ajouts et les modifications
        public InfoVehiculeForm(bool modeModification)
        {
            InitializeComponent();
            this.modeModification = modeModification;
        }

        private void InfoVehiculeForm_Load(object sender, EventArgs e)
        {
            if (modeModification)
            {
                // mode modification
                grbInfoPermanente.Enabled = false;
                btnConfirmation.Text = "Modifier";
            }
            else
            {
                // mode ajout
                btnConfirmation.Text = "Ajouter";
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            if (modeModification)
            {
                // fait la modification
                MessageBox.Show("Modification du véhicule effectué avec succès!");
                Close();
            }
            else
            {
                // fait l'ajout
                MessageBox.Show("Ajout du véhicule effectué avec succès!");
                Close();
            }
        }
    }
}
