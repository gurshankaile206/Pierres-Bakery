using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int numOfBread { get; set; }

    int Cost = 5;
    public int BreadCost()
    {
      if (numOfBread == 3)
      {
        return 10; 
      }
      return Cost * numOfBread;
    }
  }

  public class Pastry
  {

    
    public int numOfPastry { get; set; }

    int Cost = 2; 
    public int PastryCost()
    {
      if (numOfPastry == 3)
      {
        return 5;
      } else if (numOfPastry == 1)
      {
        return 2;
      } else
      {
        return numOfPastry * Cost;
      }
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
      Console.WriteLine("Enter in the number of pastries you would like to order!");
      int numOfPastry = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter in the number the loafs of bread you would like.");
      int numOfBread = int.Parse(Console.ReadLine());

      Pastry oPastry = new Pastry();
      oPastry.numOfPastry = numOfPastry;
      Console.WriteLine("Total Cost of Pastries: ");
      Console.WriteLine(oPastry.PastryCost());
      



    }
  }
}