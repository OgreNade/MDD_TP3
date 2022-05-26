using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfa_MDD_TP3.Vehicule_Logic;
using wfa_MDD_TP3.Location_Logic;
using wfa_MDD_TP3.Client_Logic;
using wfa_MDD_TP3.Connexion_Logic;

namespace wfa_MDD_TP3
{
    public class SystemeGeneral
    {
        public SystemeDeVehicule systemeDeVehicule { get; }
        public SystemeDeLocation SystemeDeLocation { get; }
        public UtilisateurManager utilisateurManager { get; }

        public SystemeGeneral()
        {
            utilisateurManager = new UtilisateurManager();
            systemeDeVehicule = new SystemeDeVehicule();
            SystemeDeLocation = new SystemeDeLocation();
        }
    }
}