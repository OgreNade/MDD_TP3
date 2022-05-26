using Microsoft.VisualStudio.TestTools.UnitTesting;
using wfa_MDD_TP3.Location_Logic;

namespace LocationPrestige_UnitTests.Test_Location
{
    [TestClass]
    public class Inspection_UnitTests
    {
        [TestMethod]
        public void ModifierInspection()
        {
            Inspection inspection = new Inspection(0, "test", "test");
            inspection.ModifierInsepection("test2");
            Assert.AreEqual("test2", inspection.Description);
        }
    }
}
