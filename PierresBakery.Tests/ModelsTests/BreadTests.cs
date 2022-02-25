using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    Bread testBread = new Bread();
    [TestMethod]
    public void CreateClass_CreateAnInstanceOfAClass_Bread()
    {
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void ReturnCost_LoopThroughUserOrder_Int()
    {
      Assert.AreEqual(5, testBread.CostOfBread(5));
    }
  }
}