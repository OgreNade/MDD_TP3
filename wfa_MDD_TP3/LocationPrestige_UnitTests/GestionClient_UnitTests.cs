using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using wfa_MDD_TP3.Client_Logic;

namespace Test_Client
{
    [TestClass]
    public class GestionClient_UnitTests
    {
        [TestMethod]
        public void TestAjouterUnClient()
        {
            // Arrange
            Client client = new Client(999999, "M9553-500493-99", "Malone", "Post", "05/05/95", "Homme", "418-977-5656", "418-222-7777", "WhiteIverson@gmail.com", "Actif", "16/07/2021", "Roger");
            ClientManager clientManager = new ClientManager();
            int expected = 9;

            // Act
            clientManager.AjouterClient(client);

            //Assert
            int clients = clientManager.clients.Count;
            Assert.AreEqual(expected, clients);
        }
        [TestMethod]
        public void TestGetClientParIdExistant()
        {
            // Arrange
            Client actual = new Client(999999, "M9553-500493-99", "Malone", "Post", "05/05/95", "Homme", "418-977-5656", "418-222-7777", "WhiteIverson@gmail.com", "En location", "16/07/2021", "Roger");
            ClientManager clientManager = new ClientManager();
            // Act
            clientManager.AjouterClient(actual);
            Client expected = clientManager.GetClientParId(999999);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //public void TestGetClientParIdInexistant()
        //{
        //    // Arrange
            
        //    ClientManager clientManager = new ClientManager();
        //    // Act
        //    Client expected = clientManager.GetClientParId(999999);
        //    //Assert
        //    Assert.AreEqual(expected, null);
        //}
    }
}
