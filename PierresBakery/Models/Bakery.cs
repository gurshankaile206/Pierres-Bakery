using System;


namespace PierresBakery.Models
{
  public class Bread
  {
    public int numOfBread { get; set; }

    public int totalCost { get; set; }
    int Cost = 5;

    public int BreadCost()
    {
      if (numOfBread > 2)
      {
        totalCost = ((numOfBread / 3) * 10) + ((numOfBread % 3) * Cost);
        return totalCost;
      }
        totalCost = numOfBread * 5;
        return totalCost;
    }
  }

  public class Pastry
  {
    public int numOfPastry { get; set; }

    public int totalCost { get ; set; }

    int Cost = 2; 
    public int PastryCost()
    {
      if (numOfPastry > 2)
      {
        totalCost = ((numOfPastry / 3) * 5) + ((numOfPastry % 3) * Cost);
        return totalCost;
      }

        totalCost = (numOfPastry * Cost);
        return totalCost;
    }       
  }
}