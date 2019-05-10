using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTests : IDisposable
    {
        public void Dispose()
        {
            Client.ClearAll();
        }

        public void ClientTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brooke_kullberg_test;";
        }

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

        [TestMethod]
        public void Equals_ReturnsTrueIfPropertiesAreTheSame_Client()
        {
            // Arrange, Act
            DateTime apt =  new DateTime(2019, 05, 19);
            Client firstClient = new Client("Bart", "perm", apt, 1);
            Client secondClient = new Client("Bart", "perm", apt, 1);

            // Assert
            Assert.AreEqual(firstClient, secondClient);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_ClientList()
        {
            //Arrange
            List<Client> newList = new List<Client> { };

            //Act
            List<Client> result = Client.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsListOfClients_ClientList()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            Client firstClient = new Client("Bart", "perm", apt, 1);
            firstClient.Save();
            Client secondClient = new Client("RodeoStarr", "color", apt, 1);
            secondClient.Save();
            List<Client> newList = new List<Client> { firstClient, secondClient };

            //Act
            List<Client> result = Client.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Save_SavesToDatabase_ClientList()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            Client testClient = new Client("Bart", "perm", apt, 1);
            //Act
            testClient.Save();
            List<Client> result = Client.GetAll();
            List<Client> testList = new List<Client>{testClient};

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }

        [TestMethod]
        public void Save_AssignsIdToObject_Id()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            Client testClient = new Client("Bart", "perm", apt, 1);
            //Act
            testClient.Save();
            Client savedClient = Client.GetAll()[0];

            int result = savedClient.Id;
            int testId = testClient.Id;

            //Assert
            Assert.AreEqual(result, testId);
        }

        [TestMethod]
        public void Find_ReturnsCorrectClientFromDatabase_Client()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            Client testClient = new Client("Bart", "perm", apt, 1);
            testClient.Save();

            //Act
            Client foundClient = Client.Find(testClient.Id);

            //Assert
            Assert.AreEqual(testClient, foundClient);
        }

        [TestMethod]
        public void EditServReq_UpdatesClientServicesRequestInDatabase_String()
        {
            //Arrange
            DateTime apt =  new DateTime(2019, 05, 19);
            string service1 = "perm";
            Client newClient = new Client("Bart", service1, apt, 1);
            newClient.Save();
            string service2 = "cut";

            //Act
            newClient.EditServReq(service2);
            string result = Client.Find(newClient.Id).ServiceRequest;

            //Assert
            Assert.AreEqual(service2, result);
        }

        [TestMethod]
        public void EditApt_UpdatesClientAppointmentInDatabase_DateTime()
        {
            //Arrange
            DateTime apt1 =  new DateTime(2019, 05, 19);
            Client newClient = new Client("Bart", "perm", apt1, 1);
            newClient.Save();
            DateTime apt2 =  new DateTime(2019, 06, 06);

            //Act
            newClient.EditApt(apt2);
            DateTime result = Client.Find(newClient.Id).Appointment;

            //Assert
            Assert.AreEqual(apt2, result);
        }

    }
}
