using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.IO;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());

    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void BreadCost_DeterminesRegularCostOfBread_Int()
    {
      
      Bread oBread = new Bread();
      int numOfBread = 1;
      int Cost = 5;
      oBread.numOfBread = numOfBread;
      Assert.AreEqual(oBread.BreadCost(), Cost);

    }

    [TestMethod]
    public void BreadCost_DeterminesDiscountedCostOfBread_Int()
    {
      Bread oBread = new Bread();
      int numOfBread = 9;
      oBread.numOfBread = numOfBread;
      Assert.AreEqual(oBread.BreadCost(), 30);
    }

    [TestMethod]
    public void PastyCost_DeterminesRegularCostOfPastry_Int()
    {
      Pastry oPastry = new Pastry();
      int numOfPastry = 1;
      int Cost = 2;
      oPastry.numOfPastry = numOfPastry;
      Assert.AreEqual(oPastry.PastryCost(), Cost);
    }

  }













  // [TestClass]
  // public class BreadTests
  // {
  //   private Bread _bread;
  //   public BreadTests()
  //   {
  //     _bread = new Bread();
  //   }
  //   [TestMethod]
  //   public void BreadCostTest()
  //   {
  //       _bread.numOfBread = 3;
  //       Assert.AreEqual(_bread.BreadCost(), 10);

  //       _bread.numOfBread = 10;
  //       Assert.AreEqual(_bread.BreadCost(), 10 *  5);

  //   }
  // }
  // [TestClass]
  // public class PastryTests
  // {
  //   private Pastry _pastry;
  //   public PastryTests()
  //   {
  //     _pastry = new Pastry();
  //   }
  //   [TestMethod]
  //   public void PastryCostTest()
  //   {
  //       _pastry.numOfPastry = 3;
  //       Assert.AreEqual(_pastry.PastryCost(), 5); // disocunt test

  //       _pastry.numOfPastry = 1;
  //       Assert.AreEqual(_pastry.PastryCost(), 2); // regular amount test

  //       _pastry.numOfPastry = 10;
  //       Assert.AreEqual(_pastry.PastryCost(), 10*2); // 
  //   }
  // }
  
}