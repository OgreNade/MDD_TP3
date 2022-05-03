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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGestionVehicule_Click(object sender, EventArgs e)
        {
            GestionVehiculeForm gestionVehiculeForm = new GestionVehiculeForm();
            gestionVehiculeForm.ShowDialog();
        }
    }
}
