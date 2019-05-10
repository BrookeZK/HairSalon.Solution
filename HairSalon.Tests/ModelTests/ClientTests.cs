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
        public void GetName_ReturnsName_String()
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

        [TestMethod]
        public void GetServicesRequested_ReturnsServicesRequested_String()
        {
            //Arrange
            string serviceReq = "hair cut";
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", serviceReq, apt, 1);

            //Act
            string result = newClient.ServiceRequest;

            //Assert
            Assert.AreEqual(serviceReq, result);
        }

        [TestMethod]
        public void SetServicesRequested_UpdateServicesRequested_String()
        {
            //Arrange
            string serviceReq = "hair cut";
            string serviceReq2 = "perm";
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", serviceReq, apt, 1);

            //Act
            string result = newClient.ServiceRequest = serviceReq2;

            //Assert
            Assert.AreEqual(serviceReq2, result);
        }

        [TestMethod]
        public void GetAppointment_ReturnsAppointment_DateTime()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", "perm", apt, 1);

            //Act
            DateTime result = newClient.Appointment;

            //Assert
            Assert.AreEqual(apt, result);
        }

        [TestMethod]
        public void SetAppointment_UpdateAppointment_DateTime()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            DateTime apt2 =  new DateTime(2019, 05, 17);
            Client newClient = new Client("Bart", "perm", apt, 1);

            //Act
            DateTime result = newClient.Appointment = apt2;

            //Assert
            Assert.AreEqual(apt2, result);
        }

        [TestMethod]
        public void GetStylistId_ReturnsStylistId_Int()
        {
            //Arrange
            int id = 1;
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", "perm", apt, id);

            //Act
            int result = newClient.StylistId;

            //Assert
            Assert.AreEqual(id, result);
        }

        [TestMethod]
        public void SetStylistId_UpdateStylistId_Int()
        {
            //Arrange
            int id = 1;
            int id2 = 2;
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", "perm", apt, id);

            //Act
            int result = newClient.StylistId = id2;

            //Assert
            Assert.AreEqual(id2, result);
        }

        [TestMethod]
        public void GetId_ReturnsId_Int()
        {
            //Arrange
            int id = 0;
            DateTime apt =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", "perm", apt, 1);

            //Act
            int result = newClient.Id;

            //Assert
            Assert.AreEqual(id, result);
        }

    }
}
