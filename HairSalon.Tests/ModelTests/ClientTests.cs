using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void ClientConstructor_CreatesInstanceOfClient_Client()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", "hair cut", apt, 1);

            //Assert
            Assert.AreEqual(typeof(Client), newClient.GetType());
        }

        [TestMethod]
        public void GetName_Returnsname_String()
        {
            //Arrange
            string name = "Bart";
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client(name, "hair cut", apt, 1);

            //Act
            string result = newClient.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void SetName_UpdateNameValue_String()
        {
            //Arrange
            string name = "Bart";
            string name2 = "Frankle";
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client(name, "hair cut", apt, 1);

            //Act
            string result = newClient.Name = name2;

            //Assert
            Assert.AreEqual(name2, result);
        }

    }
}
