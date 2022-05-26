using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Connexion_Logic
{
    public class EmployeeManager
    {
        public List<Employee> utilisateurs;
        public EmployeeManager()
        {
            utilisateurs = new List<Employee>();

            utilisateurs.Add(new EmployeeNonAdmin("RogerQ@LocationPrestige.com", "nonadmin"));
            utilisateurs.Add(new EmployeeAdmin("DamienT@LocationPrestige.com", "admin"));
        }
        public List<Employee> GetAllUtilisateur()
        {
            return utilisateurs;
        }
    }
}