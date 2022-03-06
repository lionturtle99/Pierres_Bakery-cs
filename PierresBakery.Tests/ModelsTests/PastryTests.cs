using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
  public void CreateClass_CreateAnInstanceOfAClass_Pastry()
    {
      string name = "customer";
      Pastry testPastry = new Pastry(name);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    } 

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "customer";

      Pastry testPastry = new Pastry(name);
      string result = testPastry.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Ren";
      Pastry testPastry = new Pastry(name);

      string updatedName = "Niu";
      testPastry.Name = updatedName;
      string result = testPastry.Name;

      Assert.AreEqual("good fail", result);
    }

    [TestMethod]
    public void ReturnCost_GoToIfStatement_Int()
    {
      string name = "customer";
      Pastry testPastry = new Pastry(name);
      Assert.AreEqual(10, testPastry.CostOfPastry(6));
    }

    [TestMethod]
    public void ReturnCost_GoToElseStatement_Int()
    {
      string name = "customer";
      Pastry testPastry = new Pastry(name);
      Assert.AreEqual(4, testPastry.CostOfPastry(2));
    }
  }
}