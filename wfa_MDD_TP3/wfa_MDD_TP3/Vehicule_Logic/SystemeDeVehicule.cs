using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Vehicule_Logic
{
    public class SystemeDeVehicule
    {
        private IList<Vehicule> Vehicules;

        public SystemeDeVehicule() // Constructeur par default avec donne hardcoder
        {
            Vehicules = new List<Vehicule>();

            Vehicules.Add(new Voiture("1ZVBP8CHXA5100001", "Ford", "Mustang", 2015, 75.99, "Bleu", 35078, Etat.Disponible));
            Vehicules.Add(new Voiture("1WPTY6G5VA23067HQ", "Ford", "Mustang", 2014, 55.99, "Noir", 44583, Etat.Disponible));
            Vehicules.Add(new Voiture("55WTY4G6GA6T2B6DB", "Ford", "Escape", 2021, 89.99, "Rouge", 6203, Etat.Endomage));
        }

        public bool AjouterVehicule(Vehicule vehicule) 
        {

            Vehicules.Add(vehicule);

            return true;
        }

        public bool SupprimerVehicule(string noSerie)
        {
            Vehicules.Remove(GetVehiculeByNoSerie(noSerie));

            return true;
        }

        public Vehicule GetVehiculeByNoSerie(string noSerie) // returns null if no vehicule is found
        {
            Vehicule vehiculeTrouver = null;

            for (int i = 0; vehiculeTrouver == null && i < Vehicules.Count; i++)
            {
                if (Vehicules[i].NoSerie == noSerie)
                {
                    vehiculeTrouver = Vehicules[i];
                }
            }

            return vehiculeTrouver;
        }

        public IList<Vehicule> GetAllVehicules()
        {
            return Vehicules;
        }
    }
}
