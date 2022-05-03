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
    public partial class GestionVehiculeForm : Form
    {
        public GestionVehiculeForm()
        {
            InitializeComponent();
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
    }
}
