using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.TestTools
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

    [TestMethod]
    public void GetId_ReturnsInt_Int()
    {
      Vendor testVendor = new Vendor("test vendor", "test description");
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "Pete's Coffee";
      string vendorName2 = "Bigfoot Java";
      Vendor testVendor1 = new Vendor(vendorName1, "description");
      Vendor testVendor2 = new Vendor(vendorName2, "description");
      List<Vendor> newList = new List<Vendor> { testVendor1, testVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}