using System;

namespace PierresBakery.Models
{
  public class Bread
  {
   
    public int BreadCost()
    {
      
    }
  }

  public class Pastry
  {
    public int PastryCost()
    {
      
    }
  }

  public class Bake
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We're offering the following deals today!");
      Console.WriteLine("Bread: buy 2, get 1 free. A single loaf costs $5");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5");
    }
  }
}