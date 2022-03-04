using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.TestTools
{
  [TestClass]
  public class VendorTests 
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("Pete's Coffee", "description");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsString_String()
    {
      string testVendorName = "Pete's Coffee";
      Vendor testVendor = new Vendor(testVendorName, "description");
      string result = testVendor.Name;
      Assert.AreEqual(testVendorName, result);
    }
  }
}