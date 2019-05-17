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

    }
}
