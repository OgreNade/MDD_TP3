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

        //SystemeDeVehicule() // Constructeur par default habituel
        //{
        //    Vehicules = new List<Vehicule>();
        //}

        public SystemeDeVehicule() // Constructeur par default avec donne hardcoder
        {
            Vehicules = new List<Vehicule>();

            Vehicules.Add(new Voiture("1ZVBP8CHXA5100001", "Ford", "Mustang", 2015, 75.99, "Bleu", 35078, Etat.Disponible));
            Vehicules.Add(new Voiture("1WPTY6G5VA23067HQ", "Ford", "Mustang", 2014, 55.99, "Noir", 44583, Etat.Disponible));
            Vehicules.Add(new Voiture("55WTY4G6GA6T2B6DB", "Ford", "Escape", 2021, 89.99, "Rouge", 6203, Etat.Endomage));
        }

        public bool AjouterVehicule(Vehicule vehicule) 
        {
            // TODO: Verifier que les donnee de la voiture sont valides

            Vehicules.Add(vehicule);

            return true;
        }

        public bool ModifierVehicule(Vehicule vehiculeModifier)
        {
            // TODO: Verifier que les donnee de la vehiculeModifier sont valides

            Vehicule vehiculeOriginal = GetVehiculeByNoSerie(vehiculeModifier.NoSerie);

            // TODO: Modifier la voiture

            return true;
        }

        public bool SupprimerVehicule(string noSerie)
        {
            Vehicules.Remove(GetVehiculeByNoSerie(noSerie));

            return true;
        }

        public Vehicule GetVehiculeByNoSerie(string noSerie)
        {
            Vehicule vehiculeTrouver = null;

            for (int i = 0; vehiculeTrouver == null && i < Vehicules.Count; i++)
            {
                if (Vehicules[i].NoSerie == noSerie)
                {
                    vehiculeTrouver = Vehicules[i];
                }
            }

            if (vehiculeTrouver == null)
                throw new Exception("Aucun vehicule n'a été trouvé avec ce numéro de série");

            return vehiculeTrouver;
        }

        public IList<Vehicule> GetAllVehicules()
        {
            return Vehicules;
        }
    }
}
