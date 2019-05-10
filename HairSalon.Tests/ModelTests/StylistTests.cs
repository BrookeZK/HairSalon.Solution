using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests : IDisposable
    {
        public void Dispose()
        {
            Stylist.ClearAll();
        }

        public void StylistTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brooke_kullberg_test;";
        }

        [TestMethod]
        public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
        {
            //Arrange
            Stylist newStylist = new Stylist("Andrea", 5, "Mon-Fri");

            //Assert
            Assert.AreEqual(typeof(Stylist), newStylist.GetType());
        }

        [TestMethod]
        public void GetName_Returnsname_String()
        {
            //Arrange
            string name = "Andrea";
            Stylist newStylist = new Stylist(name, 5, "Mon-Fri");

            //Act
            string result = newStylist.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void SetName_UpdateNameValue_String()
        {
            //Arrange
            string name = "Andrea";
            string name2 = "Brodie";
            Stylist newStylist = new Stylist(name, 5, "Mon-Fri");

            //Act
            string result = newStylist.Name = name2;

            //Assert
            Assert.AreEqual(name2, result);
        }

        [TestMethod]
        public void GetYearsOfExperience_ReturnsYearsOfExperience_Int()
        {
            //Arrange
            int years = 3;
            Stylist newStylist = new Stylist("Andrea", years, "Mon-Fri");

            //Act
            int result = newStylist.YearsExperience;

            //Assert
            Assert.AreEqual(years, result);
        }

        [TestMethod]
        public void SetYearsOfExperience_ReturnsYearsOfExperience_Int()
        {
            //Arrange
            int years = 3;
            int yearsNew = 5;
            Stylist newStylist = new Stylist("Andrea", years, "Mon-Fri");

            //Act
            int result = newStylist.YearsExperience = yearsNew;

            //Assert
            Assert.AreEqual(yearsNew, result);
        }

        [TestMethod]
        public void GetWorkDays_ReturnsWorkDays_String()
        {
            //Arrange
            string workDays = "Mon-Fri";
            Stylist newStylist = new Stylist("Andrea", 3, workDays);

            //Act
            string result = newStylist.WorkDays;

            //Assert
            Assert.AreEqual(workDays, result);
        }

        [TestMethod]
        public void SetWorkDays_ReturnsWorkDays_String()
        {
            //Arrange
            string workDays = "Mon-Fri";
            string newWorkDays = "Thurs-Mon";
            Stylist newStylist = new Stylist("Andrea", 3, workDays);

            //Act
            string result = newStylist.WorkDays = newWorkDays;

            //Assert
            Assert.AreEqual(newWorkDays, result);
        }

        [TestMethod]
        public void GetId_ReturnsId_Int()
        {
            //Arrange
            int id = 0;
            Stylist newStylist = new Stylist("Andrea", 3, "Mon-Fri");

            //Act
            int result = newStylist.Id;

            //Assert
            Assert.AreEqual(id, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_StylistList()
        {
            //Arrange
            List<Stylist> newList = new List<Stylist> { };

            //Act
            List<Stylist> result = Stylist.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfPropertiesAreTheSame_Stylist()
        {
          // Arrange, Act
          Stylist firstStylist = new Stylist("Andrea", 3, "Mon-Fri");
          Stylist secondStylist = new Stylist("Andrea", 3, "Mon-Fri");

          // Assert
          Assert.AreEqual(firstStylist, secondStylist);
        }

        [TestMethod]
        public void Save_SavesToDatabase_StylistList()
        {
            //Arrange
            Stylist testStylist = new Stylist("Andrea", 3, "Mon-Fri");

            //Act
            testStylist.Save();
            List<Stylist> result = Stylist.GetAll();
            List<Stylist> testList = new List<Stylist>{testStylist};

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }

        [TestMethod]
        public void Save_AssignsIdToObject_Id()
        {
            //Arrange
            Stylist newStylist = new Stylist("Andrea", 3, "Mon-Fri");
            //Act
            newStylist.Save();
            Stylist savedStylist = Stylist.GetAll()[0];

            int result = savedStylist.Id;
            int testId = newStylist.Id;

            //Assert
            Assert.AreEqual(result, testId);
        }

        [TestMethod]
        public void GetAll_ReturnsListOfStylists_StylistList()
        {
            //Arrange
            Stylist firstStylist = new Stylist("Andrea", 3, "Mon-Fri");
            firstStylist.Save();
            Stylist secondStylist = new Stylist("Brodie", 5, "Thurs-Mon");
            secondStylist.Save();
            List<Stylist> newList = new List<Stylist> { firstStylist, secondStylist };

            //Act
            List<Stylist> result = Stylist.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectStylistFromDatabase_Stylist()
        {
            //Arrange
            Stylist newStylist = new Stylist("Andrea", 3, "Mon-Fri");
            newStylist.Save();

            //Act
            Stylist foundStylist = Stylist.Find(newStylist.Id);

            //Assert
            Assert.AreEqual(newStylist, foundStylist);
        }

    }
}
