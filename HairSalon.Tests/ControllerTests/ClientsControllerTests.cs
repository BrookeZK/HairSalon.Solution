using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientsControllerTest
    {
        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            //Arrange
            ClientsController controller = new ClientsController();

            //Act
            ActionResult newView = controller.New(1);

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_HasCorrectModelType_Stylist()
        {
            //Arrange
             ViewResult newView = new ClientsController().New(1) as ViewResult;

            //Act
            var result = newView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Stylist));
        }

        [TestMethod]
        public void Show_ReturnsCorrectView_True()
        {
            //Arrange
            ClientsController controller = new ClientsController();

            //Act
            ActionResult newView = controller.Show(1, 3);

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_DictionaryOfStringAndObject()
        {
            //Arrange
             ViewResult showView = new ClientsController().Show(1, 3) as ViewResult;

            //Act
            var result = showView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
        }

        [TestMethod]
        public void Edit_ReturnsCorrectView_True()
        {
            //Arrange
            ClientsController controller = new ClientsController();

            //Act
            ActionResult newView = controller.Edit(2, 4);

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Edit_HasCorrectModelType_DictionaryOfStringAndObject()
        {
            //Arrange
             ViewResult editView = new ClientsController().Edit(2, 4) as ViewResult;

            //Act
            var result = editView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
        }

    }
}
