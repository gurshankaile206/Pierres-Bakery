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