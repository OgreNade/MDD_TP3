using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Vehicule_Logic
{
    public class Voiture : Vehicule
    {

        public Voiture(string noSerie, string marque, string modele, int annee, double prix, string couleur, int kilometrage, Etat etatCourent):base(noSerie,marque,modele,annee,prix,couleur,kilometrage,etatCourent)
        {
        }

        public Voiture(Voiture voiture) : base(voiture)
        {
        }
    }
}
