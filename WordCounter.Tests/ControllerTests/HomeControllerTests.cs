using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          //Arrange
          GamesController controller = new GamesController();

          //Act
          ActionResult indexView = controller.InputForm();

          //Assert
          Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
    }
}
