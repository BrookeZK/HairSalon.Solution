using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistsControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            StylistsController controller = new StylistsController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_StylistList()
        {
            //Arrange
             ViewResult indexView = new StylistsController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Stylist>));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            //Arrange
            StylistsController controller = new StylistsController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_ReturnsCorrectView_True()
        {
            //Arrange
            StylistsController controller = new StylistsController();

            //Act
            ActionResult showView = controller.Show(1);

            //Assert
            Assert.IsInstanceOfType(showView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_DictionaryOfStringAndObject()
        {
            //Arrange
             ViewResult showView = new StylistsController().Show(1) as ViewResult;

            //Act
            var result = showView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
        }

        [TestMethod]
        public void Edit_ReturnsCorrectView_True()
        {
            //Arrange
            StylistsController controller = new StylistsController();

            //Act
            ActionResult editView = controller.Edit(2);

            //Assert
            Assert.IsInstanceOfType(editView, typeof(ViewResult));
        }

        [TestMethod]
        public void Edit_HasCorrectModelType_Stylist()
        {
            //Arrange
             ViewResult editView = new StylistsController().Edit(2) as ViewResult;

            //Act
            var result = editView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Stylist));
        }

    }
}
