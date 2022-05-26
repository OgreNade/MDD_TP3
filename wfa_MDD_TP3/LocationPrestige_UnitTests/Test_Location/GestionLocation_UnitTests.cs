using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using wfa_MDD_TP3.Location_Logic;

namespace LocationPrestige_UnitTests.Test_Location
{
    [TestClass]
    public class GestionLocation_UnitTests
    {
        [TestMethod]
        public void TestAjouteLocation()
        {
            SystemeDeLocation systemeDeLocation = new();
            Inspection inspection = new Inspection(0, "test", "test");
            List<Inspection> inspections = new List<Inspection>();
            inspections.Add(inspection);
            Location locationTest = new Location(systemeDeLocation.GetAllLocations().Count, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), 0, "test", 0, 50, Etat.Location, inspections, inspections, "test", 50, 0);
            systemeDeLocation.AjouterLocation(locationTest);
            Assert.AreEqual(locationTest, systemeDeLocation.GetAllLocations()[systemeDeLocation.GetAllLocations().Count - 1]);
        }

        [TestMethod]
        public void TestGetLocationByNoLocation()
        {
            SystemeDeLocation systemeDeLocation = new();
            Inspection inspection = new Inspection(0, "test", "test");
            List<Inspection> inspections = new List<Inspection>();
            inspections.Add(inspection);
            Location locationTest = new Location(5000, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), 0, "test", 0, 50, Etat.Location, inspections, inspections, "test", 50, 0);
            systemeDeLocation.AjouterLocation(locationTest);
            Assert.AreEqual(locationTest, systemeDeLocation.GetLocationByNoLocation(5000));
        }

        [TestMethod]
        public void TestSupprimerLocation()
        {
            IList<Location> locations = new List<Location>();
            SystemeDeLocation systemeDeLocation = new();
            locations = systemeDeLocation.GetAllLocations();
            Inspection inspection = new Inspection(0, "test", "test");
            List<Inspection> inspections = new List<Inspection>();
            inspections.Add(inspection);
            Location locationTest = new Location(5000, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), 0, "test", 0, 50, Etat.Location, inspections, inspections, "test", 50, 0);
            systemeDeLocation.AjouterLocation(locationTest);
            systemeDeLocation.SupprimerLocation(5000);
            Assert.AreEqual(locations, systemeDeLocation.GetAllLocations());
        }
    }
}
