using System;
using System.Collections.Generic;

namespace wfa_MDD_TP3.Client_Logic
{
    public class Client
    {
        public int IdClient { get; set; }
        public string NoPermitConduire { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string DateNaissanceHC { get; set; }
        public string Genre { get; set; }
        public string Telephone { get; set; }
        public string Cellulaire { get; set; }
        public string Courriel { get; set; }
        public string Statue { get; set; }
        public string DateCreation { get; set; }
        public string CreerPar { get; set; }
        public List<Client> clients { get; set; }
        public Client(int idClient, string noPermitConduire, string nom, string prenom, DateTime dateDeNaissance, string genre, string telephone, string cellulaire, string courriel, string statue, string dateCreation, string creerPar)
        {
            IdClient = idClient;
            NoPermitConduire = noPermitConduire;
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            Genre = genre;
            Telephone = telephone;
            Cellulaire = cellulaire;
            Courriel = courriel;
            Statue = statue;
            DateCreation = dateCreation;
            CreerPar = creerPar;
        }
        public Client(int idClient, string noPermitConduire, string nom, string prenom, string dateDeNaissance, string genre, string telephone, string cellulaire, string courriel, string statue, string dateCreation, string creerPar)
        {
            IdClient = idClient;
            NoPermitConduire = noPermitConduire;
            Nom = nom;
            Prenom = prenom;
            DateNaissanceHC = dateDeNaissance;
            Genre = genre;
            Telephone = telephone;
            Cellulaire = cellulaire;
            Courriel = courriel;
            Statue = statue;
            DateCreation = dateCreation;
            CreerPar = creerPar;
        }
        public Client()
        {

        }


    }
}

