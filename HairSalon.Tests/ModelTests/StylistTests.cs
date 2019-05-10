using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests
    {
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


    }
}
