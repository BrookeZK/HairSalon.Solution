using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class SpecialtyTests : IDisposable
    {
        public void Dispose()
        {
            Specialty.ClearAll();
        }

        public void SpecialtyTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brooke_kullberg_test;";
        }

        [TestMethod]
        public void SpecialtyConstructor_CreatesInstanceOfClient_Specialty()
        {
            //Arrange
            Specialty newSpecialty = new Specialty("hair");

            //Assert
            Assert.AreEqual(typeof(Specialty), newSpecialty.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "hair";
            Specialty newSpecialty = new Specialty(name);

            //Act
            string result = newSpecialty.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void SetName_UpdateName_String()
        {
            //Arrange
            string name1 = "hair";
            string name2 = "color";
            Specialty newSpecialty = new Specialty(name1);

            //Act
            string result = newSpecialty.Name = name2;

            //Assert
            Assert.AreEqual(name2, result);
        }

        [TestMethod]
        public void GetId_ReturnsId_Int()
        {
            //Arrange
            int id = 2;
            Specialty newSpecialty = new Specialty("hair", id);

            //Act
            int result = newSpecialty.Id;

            //Assert
            Assert.AreEqual(id, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfPropertiesAreTheSame_Specialty()
        {
            // Arrange, Act
            Specialty firstSpecialty = new Specialty("hair");
            Specialty secondSpecialty = new Specialty("hair");

            // Assert
            Assert.AreEqual(firstSpecialty, secondSpecialty);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_SpecialtyList()
        {
            //Arrange
            List<Specialty> newList = new List<Specialty> { };

            //Act
            List<Specialty> result = Specialty.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
        //
        // [TestMethod]
        // public void GetAll_ReturnsListOfSpecialties_SpecialtyList()
        // {
        //     //Arrange
        //     Specialty firstSpecialty = new Specialty("hair");
        //     firstSpecialty.Save();
        //     Specialty secondSpecialty = new Specialty("color");
        //     secondSpecialty.Save();
        //     List<Specialty> newList = new List<Specialty> { firstSpecialty, secondSpecialty };
        //
        //     //Act
        //     List<Specialty> result = Specialty.GetAll();
        //
        //     //Assert
        //     CollectionAssert.AreEqual(newList, result);
        // }
        //
        [TestMethod]
        public void Save_SavesToDatabase_SpecialtyList()
        {
            //Arrange
            Specialty testSpecialty = new Specialty("perm");
            //Act
            testSpecialty.Save();
            List<Specialty> result = Specialty.GetAll();
            List<Specialty> testList = new List<Specialty>{testSpecialty};

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }
        //
        // [TestMethod]
        // public void Save_AssignsIdToObject_Id()
        // {
        //     //Arrange
        //     DateTime apt =  new DateTime(2019, 05, 19);
        //     Client testClient = new Client("Bart", "perm", apt, 1);
        //     //Act
        //     testClient.Save();
        //     Client savedClient = Client.GetAll()[0];
        //
        //     int result = savedClient.Id;
        //     int testId = testClient.Id;
        //
        //     //Assert
        //     Assert.AreEqual(result, testId);
        // }

    }
}
