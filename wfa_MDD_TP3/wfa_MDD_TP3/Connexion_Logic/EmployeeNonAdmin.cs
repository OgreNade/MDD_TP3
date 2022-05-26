using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Connexion_Logic
{
    public class EmployeeNonAdmin : Employee
    {

        
        public EmployeeNonAdmin(string emailUtilisateur, string MDP_utilisateur) : base(emailUtilisateur, MDP_utilisateur)
        {
            
        }
    }
}
