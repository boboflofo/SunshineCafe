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

  }
}