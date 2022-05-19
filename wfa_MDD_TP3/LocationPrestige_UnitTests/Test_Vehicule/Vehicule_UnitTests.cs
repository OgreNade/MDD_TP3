using Microsoft.VisualStudio.TestTools.UnitTesting;
using wfa_MDD_TP3.Vehicule_Logic;

namespace Test_Vehicule
{
    [TestClass]
    public class Vehicule_UnitTests
    {
        [TestMethod]
        public void TestModifierUnVehicule()
        {
            // Arrange

            Vehicule vehiculeDeTest = new Voiture("NOSERIE", "MARQUE", "MODELE", 1111, 1.11, "COULEUR", 1111, Etat.Disponible);

            // Act

            vehiculeDeTest.ModifierVehicule(1.11, "ROUGE", 1111, Etat.Disponible);

            //Assert

            Assert.AreEqual("ROUGE", vehiculeDeTest.Couleur);
        }
    }
}