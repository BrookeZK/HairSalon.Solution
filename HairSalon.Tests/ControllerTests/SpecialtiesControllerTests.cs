using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class SpecialtiesControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            SpecialtiesController controller = new SpecialtiesController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_StylistList()
        {
            //Arrange
             ViewResult indexView = new SpecialtiesController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Specialty>));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            //Arrange
            SpecialtiesController controller = new SpecialtiesController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_ReturnsCorrectView_True()
        {
            //Arrange
            SpecialtiesController controller = new SpecialtiesController();

            //Act
            ActionResult showView = controller.Show(1);

            //Assert
            Assert.IsInstanceOfType(showView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_StylistList()
        {
            //Arrange
             ViewResult showView = new SpecialtiesController().Show(1) as ViewResult;

            //Act
            var result = showView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
        }

        [TestMethod]
        public void Edit_ReturnsCorrectView_True()
        {
            //Arrange
            SpecialtiesController controller = new SpecialtiesController();

            //Act
            ActionResult editView = controller.Edit(2);

            //Assert
            Assert.IsInstanceOfType(editView, typeof(ViewResult));
        }

        [TestMethod]
        public void Edit_HasCorrectModelType_StylistList()
        {
            //Arrange
             ViewResult editView = new SpecialtiesController().Edit(2) as ViewResult;

            //Act
            var result = editView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Specialty));
        }

    }
}
