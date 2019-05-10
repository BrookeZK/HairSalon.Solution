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

    }
}
