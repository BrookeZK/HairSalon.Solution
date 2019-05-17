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
        public void Edit_ReturnsCorrectView_True()
        {
            //Arrange
            ClientsController controller = new ClientsController();

            //Act
            ActionResult newView = controller.Edit(2, 4);

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

    }
}
