using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using SunshineCafe.Models;

namespace SunshineCafe.Controllers
{
  public class HomeController : Controller
  {
  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }

    

  }
}