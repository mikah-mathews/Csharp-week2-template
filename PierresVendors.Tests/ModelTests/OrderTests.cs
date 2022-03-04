using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Tests
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
      Order newOrder = new Order("Tuesday: 15 croissants, 10 muffins, 8 cookies");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDetails_ReturnDetails_String()
    {
      string details = "Tuesday: 15 croissants, 10 muffins, 8 cookies";
      Order newOrder = new Order(details);
      string result = newOrder.Details;
      Assert.AreEqual(details, result);
    }

    [TestMethod]
    public void SetDetails_SetDetail_String()
    {
      string detail = "Tuesday: 15 croissants, 10 muffins, 8 cookies";
      Order newOrder = new Order(detail);
      string updatedDetail = "Tuesday: 15 croissants, 10 muffins, 20 cookies"; 
      newOrder.Details = updatedDetail;
      string result = newOrder.Details;
      Assert.AreEqual(updatedDetail, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string tuesdayOrder = "Tuesday: 15 croissants, 10 muffins, 8 cookies";
      string thursdayOrder = "Thursday: 10 croissants, 5 muffins, 5 cookies";
      Order newOrder = new Order(tuesdayOrder);
      Order secondOrder = new Order(thursdayOrder);
      List<Order> newOrderList = new List<Order> { newOrder, secondOrder };

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}