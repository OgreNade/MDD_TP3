using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_MDD_TP3.Location_Logic
{
    public class Location
    {
        public int NoLocation { get; }
        public DateTime DateStart { get; }
        public DateTime DateEnd { get; private set; }
        public int IdClient { get; }
        public string NoSerie { get; private set; }
        public int KilometrageStart { get; }
        public int KilometrageEnd { get; private set; }
        public Etat Etat { get; private set; }
        public List<Inspection> InspectionsStart { get; private set; }
        public List<Inspection> InspectionsEnd { get; private set; }
        public string MethodePaiment { get; private set; }
        public double TotalAPayer { get; private set; }
        public double MontantPayer { get; private set; }

        public Location (int noLocation, DateTime dateStart, DateTime dateEnd, int idClient, string noSerie, int kilometrageStart, int kilometrageEnd, Etat etat, List<Inspection> inspectionsStart, List<Inspection> inspectionsEnd, string methodePaiment, double totalAPayer, double montantPayer)
        {
            NoLocation = noLocation;
            DateStart = dateStart;
            DateEnd = dateEnd;
            IdClient = idClient;
            NoSerie = noSerie;
            KilometrageStart = kilometrageStart;
            KilometrageEnd = kilometrageEnd;
            Etat = etat;
            InspectionsStart = inspectionsStart;
            InspectionsEnd = inspectionsEnd;
            MethodePaiment = methodePaiment;
            TotalAPayer = totalAPayer;
            MontantPayer = montantPayer;
        }
        public Location(Location location)
        {
            NoLocation = location.NoLocation;
            DateStart = location.DateStart;
            DateEnd = location.DateEnd;
            IdClient = location.IdClient;
            NoSerie = location.NoSerie;
            KilometrageStart = location.KilometrageStart;
            KilometrageEnd = location.KilometrageEnd;
            Etat = location.Etat;
            InspectionsStart = location.InspectionsStart;
            InspectionsEnd = location.InspectionsEnd;
            MethodePaiment = location.MethodePaiment;
            TotalAPayer = location.TotalAPayer;
            MontantPayer = location.MontantPayer;
        }
        public void AddInspectionStart(string carPart, string description)
        {
            Inspection inspection = new Inspection(InspectionsStart.Count, carPart, description);
            InspectionsStart.Add(inspection);
        }
        public void AddInspectionStart(Inspection inspection)
        {
            InspectionsStart.Add(inspection);
        }
        public void AddInspectionStart(List<Inspection> inspections)
        {
            InspectionsStart.Clear();
            for (int i = 0; i < inspections.Count; i++)
            {
                InspectionsStart.Add(inspections[i]);
            }
        }
        public void ModifierInspectionStart(int NoInspection, string description)
        {
            for (int i = 0; i < InspectionsStart.Count; i++)
            {
                if (InspectionsStart[i].NoInspection == NoInspection)
                {
                    InspectionsStart[i].ModifierInsepection(description);
                }
            }
        }
        public void AddInspectionEnd(string carPart, string description)
        {
            Inspection inspection = new Inspection(InspectionsStart.Count, carPart, description);
            InspectionsEnd.Add(inspection);
        }
        public void AddInspectionEnd(Inspection inspection)
        {
            InspectionsEnd.Add(inspection);
        }
        public void AddInspectionEnd(List<Inspection> inspections)
        {
            InspectionsEnd.Clear();
            for (int i = 0; i < inspections.Count; i++)
            {
                InspectionsEnd.Add(inspections[i]);
            }
        }
        public void ModifierInspectionEnd(int NoInspection, string description)
        {
            for (int i = 0; i < InspectionsEnd.Count; i++)
            {
                if (InspectionsEnd[i].NoInspection == NoInspection)
                {
                    InspectionsEnd[i].ModifierInsepection(description);
                }
            }
        }
        public void ModifierLocation(DateTime dateEnd, string noSerie, int kilometrageEnd, Etat etat, string methodePaiement, double totalAPayer, double montantPayer)
        {
            DateEnd = dateEnd;
            NoSerie = noSerie;
            KilometrageEnd = kilometrageEnd;
            Etat = etat;
            MethodePaiment = methodePaiement;
            TotalAPayer = totalAPayer;
            MontantPayer = montantPayer;
        }
    }
}
