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
    public void TakeUserInput_ReturnUserPrice_Int()
    {
      Assert.AreEqual(2, testPastry.CostOfPastry(1));
    }
  }
}