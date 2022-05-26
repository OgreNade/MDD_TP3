using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Connexion_Logic
{
    public class Employee
    {
        public string EmailUtilisateur { get; set; }
        public string MDP_Utilisateur { get; set; }
        public Employee(string emailUtilisateur, string MDP_utilisateur)
        {
            EmailUtilisateur = emailUtilisateur;
            MDP_Utilisateur = MDP_utilisateur;
        }
    }
}
