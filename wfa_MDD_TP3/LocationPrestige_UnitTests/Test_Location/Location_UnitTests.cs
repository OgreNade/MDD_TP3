using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using wfa_MDD_TP3.Location_Logic;

namespace LocationPrestige_UnitTests.Test_Location
{
    [TestClass]
    public class Location_UnitTests
    {
        [TestMethod]
        public void TestModifierUneLocation()
        {
            Inspection inspection = new Inspection(0, "test", "test");
            List<Inspection> inspections = new List<Inspection>();
            inspections.Add(inspection);
            Location locationTest = new Location(0, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), 0, "test", 0, 20, Etat.Location, inspections, inspections, "Kilometrage", 0, 0);

            locationTest.ModifierLocation(DateTime.Now.AddDays(4), "test2", 500, Etat.Problematique, "Temps", 900, 500);

            Assert.AreEqual("test2", locationTest.NoSerie);
            Assert.AreEqual(Etat.Problematique, locationTest.Etat);
        }

        [TestMethod]
        public void TestAjouterUneInspection()
        {
            Inspection inspection = new Inspection(0, "test", "test");
            List<Inspection> inspectionsAvant = new List<Inspection>();
            List<Inspection> inspectionsApres = new List<Inspection>();
            inspectionsAvant.Add(inspection);
            inspectionsApres.Add(inspection);
            Location locationTest = new Location(0, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), 0, "test", 0, 20, Etat.Location, inspectionsAvant, inspectionsApres, "Kilometrage", 0, 0);

            locationTest.AddInspectionStart("test2", "test2");
            locationTest.AddInspectionEnd("test3", "test3");

            Assert.AreEqual("test2", locationTest.InspectionsStart[1].CarPart);
            Assert.AreEqual("test3", locationTest.InspectionsEnd[1].Description);
        }
    }
}
