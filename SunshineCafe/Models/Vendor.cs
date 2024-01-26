using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    private static List<Category> _instances = new List<Category> {};
  }
}