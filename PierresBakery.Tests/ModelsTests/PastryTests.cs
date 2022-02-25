using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    Pastry testPastry = new Pastry();
    [TestMethod]
  public void CreateClass_CreateAnInstanceOfAClass_Pastry()
    {
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    } 
    [TestMethod]
    public void ReturnCost_ReturnCostOfPastry_Int()
    {
      Assert.AreEqual(2, testPastry.CostOfPastry(1));
    }
      public void ReturnCost_ReturnCostBasedOnUserInput_Int()
    {
      Assert.AreEqual(5, testPastry.CostOfPastry(3));
    }
  }
}