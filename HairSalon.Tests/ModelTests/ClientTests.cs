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

    }
}
