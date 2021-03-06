using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Location_Logic
{
    public class SystemeDeLocation
    {
        private IList<Location> Locations;
        public SystemeDeLocation()
        {
            List<Inspection> inspectionsAvant1 = new List<Inspection>();
            inspectionsAvant1.Add(new Inspection(0, "Aile droite", "Graffigne"));
            inspectionsAvant1.Add(new Inspection(1, "Pare-brise", "Éclat dans le bas a droite"));
            inspectionsAvant1.Add(new Inspection(2, "Siège passager", "Tache noir sur le dossier"));

            List<Inspection> inspectionsAprès1 = new List<Inspection>();
            inspectionsAprès1.Add(new Inspection(0, "Aile droite", "Graffigne"));
            inspectionsAprès1.Add(new Inspection(1, "Pare-brise", "Éclat dans le bas a droite"));
            inspectionsAprès1.Add(new Inspection(2, "Siège passager", "Tache noir sur le dossier"));
            inspectionsAprès1.Add(new Inspection(3, "Vitre arrière côté conducteur", "Le bouton ne fonctionne plus"));

            List<Inspection> inspectionsAvant2 = new List<Inspection>();
            inspectionsAvant2.Add(new Inspection(2, "Siège passager", "Tache noir sur le dossier"));

            List<Inspection> inspectionsAprès2 = new List<Inspection>();
            inspectionsAprès2.Add(new Inspection(1, "Pare-brise", "Éclat dans le bas a droite"));
            inspectionsAprès2.Add(new Inspection(2, "Siège passager", "Tache noir sur le dossier"));
            inspectionsAprès2.Add(new Inspection(3, "Vitre arrière côté conducteur", "Le bouton ne fonctionne plus"));

            Locations = new List<Location>();
            Locations.Add(new Location(0, DateTime.Now.AddDays(2), DateTime.Now.AddDays(2), 3, "1ZVBP8CHXA5100001", 35078, 35078, Etat.Location, inspectionsAvant1, inspectionsAprès1, "Kilometrage", 0, 15));
            Locations.Add(new Location(1, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1), 1, "1WPTY6G5VA23067HQ", 44583, 44583, Etat.Location, inspectionsAvant2, inspectionsAprès2, "Temps", 0, 50));
        }
        
        public bool AjouterLocation(Location location)
        {
            Locations.Add(location);
            return true;
        }

        public bool SupprimerLocation(int NoLocation)
        {
            Locations.Remove(GetLocationByNoLocation(NoLocation));
            return true;
        }
        public Location GetLocationByNoLocation(int noLocation)
        {
            Location location = null;
            for (int i = 0; i < Locations.Count; i++)
            {
                if (Locations[i].NoLocation == noLocation)
                {
                    location = Locations[i];
                }
            }
            return location;
        }
        public IList<Location> GetAllLocations()
        {
            return Locations;
        }
        public IList<Location> GetFutureLocations()
        {
            IList<Location> futureLocations = new List<Location>();
            for (int i = 0; i < Locations.Count; i++)
            {
                if (Locations[i].DateEnd >= DateTime.Now)
                {
                    futureLocations.Add(Locations[i]);
                }
            }
            return futureLocations;
        }
        public void ModifierLocation(Location location)
        {
            for (int i = 0; i < Locations.Count; i++)
            {
                if (Locations[i].NoLocation == location.NoLocation)
                {
                    Locations[i].ModifierLocation(location.DateEnd, location.NoSerie, location.KilometrageEnd, location.Etat, location.MethodePaiment, location.TotalAPayer, location.MontantPayer);
                    Locations[i].AddInspectionStart(location.InspectionsStart.ToList());
                    Locations[i].AddInspectionEnd(location.InspectionsEnd.ToList());
                }
            }
        }
    }
}
