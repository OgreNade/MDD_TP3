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
using wfa_MDD_TP3.Vehicule_Logic;

namespace wfa_MDD_TP3
{
    public partial class MainForm : Form
    {
        SystemeGeneral systemeGeneral;
        public MainForm(SystemeGeneral systemeGeneral)
        {
            InitializeComponent();
            this.systemeGeneral = systemeGeneral;
        }

        private void btnGestionVehicule_Click(object sender, EventArgs e)
        {
            GestionVehiculeForm gestionVehiculeForm = new GestionVehiculeForm(systemeGeneral.systemeDeVehicule);
            gestionVehiculeForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_GestionClient_Click(object sender, EventArgs e)
        {
            GestionClientsFrm gestionClientForm = new GestionClientsFrm();
            gestionClientForm.ShowDialog();

        }
    }
}
