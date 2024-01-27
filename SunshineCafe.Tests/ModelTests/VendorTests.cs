using Microsoft.VisualStudio.TestTools.UnitTesting;
using SunshineCafe.Models;
using System.Collections.Generic;
using System;

namespace SunshineCafe.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("bread", "fluffy");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "bread";
      Vendor newVendor = new Vendor(name, "fluffy");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "fluffy";
      Vendor newVendor = new Vendor("bread", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]

    public void GetId_ReturnsVendorId_Int()
    {
      string name = "bread";
      Vendor newVendor = new Vendor(name, "fluffy");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string shop1 = "Ally's";
      string shop2 = "Bob's";
      Vendor newVendor1 = new Vendor(shop1, "fluffy");
      Vendor newVendor2 = new Vendor(shop2, "hard");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string shop1 = "Ally's";
      string shop2 = "Bob's";
      Vendor newVendor1 = new Vendor(shop1, "fluffy");
      Vendor newVendor2 = new Vendor(shop2, "hard");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

[TestMethod]
  public void AddOrder_AddOrderWithVendor_OrderList()
  {
    string description = "Walk the dog.";
    Order newOrder = new Order("name", description, 10, "date");
    List<Order> newList = new List<Order> { newOrder };
    string name = "Work";
    Vendor newVendor = new Vendor(name, "fluffy");
    newVendor.AddOrder(newOrder);
    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
  }
  }
}