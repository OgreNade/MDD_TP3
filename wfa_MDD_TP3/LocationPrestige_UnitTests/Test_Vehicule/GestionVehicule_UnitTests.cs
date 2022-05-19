using Microsoft.VisualStudio.TestTools.UnitTesting;
using wfa_MDD_TP3.Vehicule_Logic;
using System;

namespace Test_Vehicule
{
    [TestClass]
    public class GestionVehicule_UnitTests
    {
        [TestMethod]
        public void TestAjouterVehicule()
        {
            // Arrange

            SystemeDeVehicule systemeDeVehicule = new();

            int nombreDeVehiculeACreation = systemeDeVehicule.GetAllVehicules().Count;

            Vehicule nouveauVehicule = new Voiture("NOSERIE", "MARQUE", "MODELE", 1111, 1.11, "COULEUR", 1111, Etat.Disponible);

            // Act

            systemeDeVehicule.AjouterVehicule(nouveauVehicule);

            //Assert

            Assert.AreEqual(nombreDeVehiculeACreation + 1, systemeDeVehicule.GetAllVehicules().Count);
        }

        [TestMethod]
        public void TestGetVehiculeByNoSerie()
        {
            // Arrange

            SystemeDeVehicule systemeDeVehicule = new();

            Vehicule nouveauVehicule = new Voiture("NOSERIE", "MARQUE", "MODELE", 1111, 1.11, "COULEUR", 1111, Etat.Disponible);

            systemeDeVehicule.AjouterVehicule(nouveauVehicule);

            // Act

            Vehicule vehiculeTrouve = systemeDeVehicule.GetVehiculeByNoSerie("NOSERIE");

            //Assert

            Assert.AreEqual(nouveauVehicule, vehiculeTrouve);
        }

        [TestMethod]
        public void TestSupprimerVehicule()
        {
            // Arrange

            SystemeDeVehicule systemeDeVehicule = new();

            Vehicule nouveauVehicule = new Voiture("NOSERIE", "MARQUE", "MODELE", 1111, 1.11, "COULEUR", 1111, Etat.Disponible);

            systemeDeVehicule.AjouterVehicule(nouveauVehicule);

            int nombreDeVehiculeAvantDelete = systemeDeVehicule.GetAllVehicules().Count;

            // Act

            systemeDeVehicule.SupprimerVehicule("NOSERIE");

            //Assert

            Assert.AreEqual(nombreDeVehiculeAvantDelete - 1, systemeDeVehicule.GetAllVehicules().Count);
            Assert.IsNull(systemeDeVehicule.GetVehiculeByNoSerie("NOSERIE"));
        }
    }
}