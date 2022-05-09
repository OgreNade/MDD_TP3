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
        public double Prix { get; }
        public string Couleur { get; }
        public int Kilometrage { get; }
        public Etat EtatCourent { get; }

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

        public override string ToString()
        {
            return $"{NoSerie} : {Marque} {Modele} {Annee} {Couleur} | Kilo: {Kilometrage} | Courament {EtatCourent}";
        }
    }
}
