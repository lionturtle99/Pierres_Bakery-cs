using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    
    [TestMethod]
    public void CreateClass_CreateAnInstanceOfAClass_Bread()
    {
      Bread testBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void ReturnCost_GoToIfStatement_Int()
    {
      Bread testBread = new Bread("test");
      Assert.AreEqual(20, testBread.CostOfBread(6));
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "customer";

      Bread testBread = new Bread(name);
      string result = testBread.Name;

      Assert.AreEqual(name, result);
    }


    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Kylo";
      Bread testBread = new Bread(name);

      string updatedName = "Peter";
      testBread.Name = updatedName;
      string result = testBread.Name;

      Assert.AreEqual("good fail", result);
    }

    [TestMethod]
    public void ReturnCost_GoToElseStatement_Int()
    {
      Bread testBread = new Bread("test");
      Assert.AreEqual(5, testBread.CostOfBread(1));
    }
  }
}