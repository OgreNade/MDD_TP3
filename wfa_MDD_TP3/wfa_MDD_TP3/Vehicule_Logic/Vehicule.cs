using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Vehicule_Logic
{
    public abstract class Vehicule
    {
        public string NoSerie { get; } 
        public string Marque { get; }
        public string Modele { get; }
        public int Annee { get; }
        public double Prix { get; private set; }
        public string Couleur { get; private set; }
        public int Kilometrage { get; private set; }
        public Etat EtatCourent { get; private set; }

        public Vehicule(string noSerie, string marque, string modele, int annee, double prix, string couleur, int kilometrage, Etat etatCourent)
        {
            NoSerie = noSerie;
            Marque = marque;
            Modele = modele;
            Annee = annee;
            Prix = prix;
            Couleur = couleur;
            Kilometrage = kilometrage;
            EtatCourent = etatCourent;
        }

        public Vehicule(Vehicule vehicule)
        {
            NoSerie = vehicule.NoSerie;
            Marque = vehicule.Marque;
            Modele = vehicule.Modele;
            Annee = vehicule.Annee;
            Prix = vehicule.Prix;
            Couleur = vehicule.Couleur;
            Kilometrage = vehicule.Kilometrage;
            EtatCourent = vehicule.EtatCourent;
        }

        public void ModifierVehicule(double prix, string couleur, int kilometrage, Etat etatCourent)
        {
            Prix = prix;
            Couleur = couleur;
            Kilometrage = kilometrage;
            EtatCourent = etatCourent;
        }

        public override string ToString()
        {
            return $"{NoSerie} : {Marque} {Modele} {Annee} {Couleur} | Kilo: {Kilometrage} | Courament {EtatCourent}";
        }
    }
}
