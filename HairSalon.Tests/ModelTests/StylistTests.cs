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
        public void Getname_Returnsname_String()
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
        public void Setname_UpdateNameValue_String()
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

    }
}
