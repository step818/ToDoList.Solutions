using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.TestTools
{
    [TestClass]
    public class ItemsControllerTest
    {

      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        ItemsController controller = new ItemsController();
        ActionResult indexView = controller.Index();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void Index_HasCorrectModelType_ItemList()
      {
        ViewResult indexView = new ItemsController().Index() as ViewResult;
        var result = indexView.ViewData.Model;
        Assert.IsInstanceOfType(result, typeof(List<Item>));
      }

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        ItemsController controller = new ItemsController();
        IActionResult view = controller.Create("Walk the dog");
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
        ItemsController controller = new ItemsController();
        RedirectToActionResult actionResult = controller.Create("walk the dog") as RedirectToActionResult;
        string result = actionResult.ActionName;
        Assert.AreEqual(result, "Index");
      }

    }
}
