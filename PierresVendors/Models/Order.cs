using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Details { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order (string details)
    {
      Details = details;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}