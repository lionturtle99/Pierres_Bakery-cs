using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CreateClass_CreateAnInstanceOfAClass_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual("test", newBread.GetType());
    }
  }
}