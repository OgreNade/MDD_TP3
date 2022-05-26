using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfa_MDD_TP3.Connexion_Logic;

namespace wfa_MDD_TP3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SystemeGeneral systemeGeneral = new SystemeGeneral();
            EmployeeManager utilisateurManager = new EmployeeManager();

            Application.Run(new Connexion(systemeGeneral));
        }
    }
}
