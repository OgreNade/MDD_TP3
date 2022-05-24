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
using wfa_MDD_TP3.Location_UI;
using wfa_MDD_TP3.Location_Logic;

namespace wfa_MDD_TP3
{
    public partial class MainForm : Form
    {
        SystemeGeneral systemeGeneral;
        SystemeDeVehicule systemeDeVehicule;
        SystemeDeLocation systemeDeLocation;
        ClientManager clientManager;
        public MainForm(SystemeGeneral systemeGeneral)
        {
            InitializeComponent();
            this.systemeGeneral = systemeGeneral;
            this.systemeDeVehicule = this.systemeGeneral.systemeDeVehicule;
            this.systemeDeLocation = this.systemeGeneral.SystemeDeLocation;
            this.clientManager = this.systemeGeneral.ClientManager;
        }

        private void btnGestionVehicule_Click(object sender, EventArgs e)
        {
            GestionVehiculeForm gestionVehiculeForm = new GestionVehiculeForm(systemeDeVehicule);
            gestionVehiculeForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_GestionClient_Click(object sender, EventArgs e)
        {
            GestionClientsFrm gestionClientForm = new GestionClientsFrm(clientManager);
            gestionClientForm.ShowDialog();

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            GestionLocationForm gestionLocationForm = new GestionLocationForm(systemeDeLocation, clientManager, systemeDeVehicule);
            gestionLocationForm.ShowDialog();

        }
    }
}
