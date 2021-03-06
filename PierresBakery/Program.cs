using System;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We're offering the following deals today!");
      Console.WriteLine("Bread: buy 2, get 1 free. A single loaf costs $5");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5");
      Console.WriteLine("Enter in the number of pastries you would like to order!");
      int numOfPastry = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter in the number the loafs of bread you would like.");
      int numOfBread = int.Parse(Console.ReadLine());

      Pastry oPastry = new Pastry();
      oPastry.numOfPastry = numOfPastry;
      Console.WriteLine("Total Cost of Pastries: ");
      Console.WriteLine(oPastry.PastryCost());

      Bread oBread = new Bread();
      oBread.numOfBread = numOfBread;
      Console.WriteLine("Total Cost of Bread: ");
      Console.WriteLine(oBread.BreadCost());

      int totalCost = oPastry.PastryCost() + oBread.BreadCost();
      Console.WriteLine("Total Cost of Order: " + totalCost + " Dollars");
    }
  }
}