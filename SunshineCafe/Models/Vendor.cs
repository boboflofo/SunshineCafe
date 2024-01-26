using System.Collections.Generic;

namespace SunshineCafe.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    // public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};
  }
}