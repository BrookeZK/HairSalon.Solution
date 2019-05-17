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

    }
}
