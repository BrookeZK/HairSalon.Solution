using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Login_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult loginView = controller.Login("Brooke");

            //Assert
            Assert.IsInstanceOfType(loginView, typeof(ViewResult));
        }

        // [TestMethod]
        // public void Login_HasCorrectModelType_string()
        // {
        //     //Arrange
        //      ViewResult loginView = new HomeController().Login("Brooke") as ViewResult;
        //
        //     //Act
        //     var result = loginView.ViewData.Model;
        //
        //     //Assert
        //     Assert.IsInstanceOfType(result, typeof(string));
        // }
    }
}
