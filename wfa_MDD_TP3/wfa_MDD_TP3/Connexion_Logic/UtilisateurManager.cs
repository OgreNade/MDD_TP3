using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Connexion_Logic
{
    public class UtilisateurManager
    {
        public List<Utilisateur> utilisateurs;
        public UtilisateurManager()
        {
            utilisateurs = new List<Utilisateur>();

            utilisateurs.Add(new Utilisateur("RogerQ@LocationPrestige.com", "admin"));
        }
        public List<Utilisateur> GetAllUtilisateur()
        {
            return utilisateurs;
        }
    }
}