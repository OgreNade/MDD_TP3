using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Vehicule_Logic
{
    public class SystemeDeVehicule
    {
        public IList<Vehicule> Vehicules { get; }

        SystemeDeVehicule(IList<Vehicule> vehicules) 
        {
            Vehicules = vehicules;
        }

        public bool AjouterVoiture(Vehicule vehicule) 
        {
            // TODO: Verifier que les donnee de la voiture sont valides

            Vehicules.Add(vehicule);

            return true;
        }

        public bool ModifierVoiture(Vehicule vehiculeModifier)
        {
            // TODO: Verifier que les donnee de la vehiculeModifier sont valides

            Vehicule vehiculeOriginal = GetVehiculeByNoSerie(vehiculeModifier.NoSerie);

            // TODO: Modifier la voiture

            return true;
        }

        public Vehicule GetVehiculeByNoSerie(string noSerie) 
        {
            throw new NotImplementedException();
        }
    }
}
