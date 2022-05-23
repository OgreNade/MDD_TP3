using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Location_Logic
{
    public class Inspection
    {
        public int NoInspection { get; }
        public string CarPart { get; }
        public string Description { get; private set; }

        public Inspection(int noInspection, string carPart, string description)
        {
            NoInspection = noInspection;
            CarPart = carPart;
            Description = description;
        }
        public Inspection(Inspection inspection)
        {
            NoInspection = inspection.NoInspection;
            CarPart = inspection.CarPart;
            Description = inspection.Description;
        }
        public void ModifierInsepection(string description)
        {
            Description = description;
        }
        public override string ToString()
        {
            return CarPart + " " + Description;
        }
    }
}
