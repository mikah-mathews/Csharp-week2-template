using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders")]
    public ActionResult Create(string details)
    {
      Order vendorOrder = new Order(details);
      return RedirectToAction("Index");
    }
  }
}