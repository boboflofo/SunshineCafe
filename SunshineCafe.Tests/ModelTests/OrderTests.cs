using Microsoft.VisualStudio.TestTools.UnitTesting;
using SunshineCafe.Models;
using System.Collections.Generic;
using System;

namespace SunshineCafe.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("bread", "fluffy", 10, "10-19-2024");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string Title = "bread";
      Order newOrder = new Order("bread", "fluffy", 10, "10-19-2024");
      string result = newOrder.Title;
      Assert.AreEqual(Title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "fluffy";
      Order newOrder = new Order("bread", description, 10, "10-19-2024");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]

    public void GetId_ReturnsOrderId_Int()
    {
      string Title = "bread";
      Order newOrder = new Order("bread", "fluffy", 10, "10-19-2024");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string milkBread = "Milk Bread";
      string raisinBread = "Raisin Bread";
      Order newOrder1 = new Order(milkBread, "fluffy", 10, "10-19-2024");
      Order newOrder2 = new Order(raisinBread, "hard", 20, "10-19-2024");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string milkBread = "Milk Bread";
      string raisinBread = "Raisin Bread";
      Order newOrder1 = new Order(milkBread, "fluffy", 10, "10-19-2024");
      Order newOrder2 = new Order(raisinBread, "hard", 20, "10-19-2024");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

  }
}