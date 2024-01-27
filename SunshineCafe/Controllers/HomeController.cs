using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using SunshineCafe.Models;

namespace SunshineCafe.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpPost("/vendors")]
  public ActionResult Create(string vendorName, string description)
  {
    Vendor newVendor = new Vendor(vendorName, description);
    return RedirectToAction("Index");
  }

    [HttpGet("/vendors/new")]
    public ActionResult New()
  {
    return View();
  }

  [HttpGet("/vendors/{id}")]
  public ActionResult Show(int id)
  {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor selectedVendor = Vendor.Find(id);
    List<Order> vendorOrders = selectedVendor.Orders;
    model.Add("vendor", selectedVendor);
    model.Add("orders", vendorOrders);
    return View(model);
  }

  }
}