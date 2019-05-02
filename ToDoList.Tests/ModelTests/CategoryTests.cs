using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {

    public void Dispose()
    {
      Category.ClearAll();
    }
    
    [TestMethod]
    public void CategoryConstructor_ChecksIfObjectGetsMade_Category()
    {
      string name = "School";
      Category newCategory = new Category(name);
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "work";
      Category newCategory = new Category(name);
      //Act
      string myWork = newCategory.GetName();
      //Assert
      Assert.AreEqual("work", myWork);
    }
    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      //Arrange
      string testName = "Monday";
      Category newCategory = new Category(testName);
      //Act
      int result = newCategory.GetId();
      //Assert
      Assert.AreEqual(1, result);
    }
  }
}
