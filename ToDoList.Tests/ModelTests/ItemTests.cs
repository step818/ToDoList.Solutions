using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("Test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.GetDescription();
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetId_ItemsInstantiateWithIdAndGetterReturns_int()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      int result = newItem.GetId();
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCoreectItem_Item()
    {
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      Item result = Item.Find(2);
      Assert.AreEqual(newItem2, result);
    }
  }
}
