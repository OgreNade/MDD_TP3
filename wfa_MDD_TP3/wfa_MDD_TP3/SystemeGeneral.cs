using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfa_MDD_TP3.Vehicule_Logic;

namespace wfa_MDD_TP3
{
    public class SystemeGeneral 
    {
        public SystemeDeVehicule systemeDeVehicule { get; }

        public SystemeGeneral()
        {
            systemeDeVehicule = new SystemeDeVehicule();
        }
    }
}
