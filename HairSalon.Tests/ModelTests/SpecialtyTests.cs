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
            Specialty newSpecialty = new Specialty("hair", 30);

            //Assert
            Assert.AreEqual(typeof(Specialty), newSpecialty.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "hair";
            Specialty newSpecialty = new Specialty(name, 30);

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
            Specialty newSpecialty = new Specialty(name1, 30);

            //Act
            string result = newSpecialty.Name = name2;

            //Assert
            Assert.AreEqual(name2, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Int()
        {
            //Arrange
            int price = 30;
            Specialty newSpecialty = new Specialty("bob", price);

            //Act
            int result = newSpecialty.Price;

            //Assert
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void SetPrice_UpdatePrice_Int()
        {
            //Arrange
            int price1 = 30;
            int price2 = 40;
            Specialty newSpecialty = new Specialty("bob", price1);

            //Act
            int result = newSpecialty.Price = price2;

            //Assert
            Assert.AreEqual(price2, result);
        }

        [TestMethod]
        public void GetId_ReturnsId_Int()
        {
            //Arrange
            int id = 2;
            Specialty newSpecialty = new Specialty("hair", 30, id);

            //Act
            int result = newSpecialty.Id;

            //Assert
            Assert.AreEqual(id, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfPropertiesAreTheSame_Specialty()
        {
            // Arrange, Act
            Specialty firstSpecialty = new Specialty("hair", 30);
            Specialty secondSpecialty = new Specialty("hair", 30);

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

        [TestMethod]
        public void GetAll_ReturnsListOfSpecialties_SpecialtyList()
        {
            //Arrange
            Specialty firstSpecialty = new Specialty("hair", 30);
            firstSpecialty.Save();
            Specialty secondSpecialty = new Specialty("color", 30);
            secondSpecialty.Save();
            List<Specialty> newList = new List<Specialty> { firstSpecialty, secondSpecialty };

            //Act
            List<Specialty> result = Specialty.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Save_SavesToDatabase_SpecialtyList()
        {
            //Arrange
            Specialty testSpecialty = new Specialty("perm", 30);

            //Act
            testSpecialty.Save();
            List<Specialty> result = Specialty.GetAll();
            List<Specialty> testList = new List<Specialty>{testSpecialty};

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }

        [TestMethod]
        public void Save_AssignsIdToObject_Id()
        {
            //Arrange
            Specialty testSpecialty = new Specialty("hair", 30);
            testSpecialty.Save();

            //Act
            Specialty savedSpecialty = Specialty.GetAll()[0];

            int result = savedSpecialty.Id;
            int testId = testSpecialty.Id;

            //Assert
            Assert.AreEqual(result, testId);
        }

        [TestMethod]
        public void Find_ReturnsCorrectSpecialtyFromDatabase_Specialty()
        {
            //Arrange
            Specialty testSpecialty1 = new Specialty("perm", 30);
            testSpecialty1.Save();
            Specialty testSpecialty2 = new Specialty("hair", 30);
            testSpecialty2.Save();

            //Act
            Specialty foundSpecialty = Specialty.Find(testSpecialty2.Id);

            //Assert
            Assert.AreEqual(testSpecialty2, foundSpecialty);
        }

        [TestMethod]
        public void Edit_UpdatesSpecialtyPropertiesInDatabase_Specialty()
        {
            //Arrange
            string name1 = "hair";
            int price1 = 30;
            Specialty newSpecialty = new Specialty(name1, price1);
            newSpecialty.Save();
            string name2 ="curly hair";
            int price2 = 35;

            //Act
            newSpecialty.Edit(name2, price2);
            Specialty result = Specialty.Find(newSpecialty.Id);

            //Assert
            Assert.AreEqual(newSpecialty, result);
        }

        [TestMethod]
        public void DeleteSpecialty_DeletesSpecialtyFromDatabase_List()
        {
            //Arrange
            Specialty firstSpecialty = new Specialty("perm", 30);
            firstSpecialty.Save();
            Specialty secondSpecialty = new Specialty("hair", 35);
            secondSpecialty.Save();
            //Act
            firstSpecialty.DeleteSpecialty();
            List<Specialty> result = Specialty.GetAll();
            List<Specialty> newList = new List<Specialty> { secondSpecialty };
            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

    }
}
