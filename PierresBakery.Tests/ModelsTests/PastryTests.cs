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
      string customer = "john";
      Pastry testPastry = new Pastry(customer);

      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    } 

    [TestMethod]
    public void GetCustomer_ReturnsCustomer_String()
    {
      string customer = "Neo";
      Pastry testPastry = new Pastry(customer);

      string result = testPastry.Customer;

      Assert.AreEqual(customer, result);
    }

    [TestMethod]
    public void SetCustomer_SetCustomer_String()
    {
      string customer = "Kylo";
      Pastry testPastry = new Pastry(customer);

      string updatedCustomer = "Ren";
      testPastry.Customer = updatedCustomer;
      string result = testPastry.Customer;

      Assert.AreEqual(updatedCustomer, result);
    }

    [TestMethod]
    public void ReturnCost_GoToIfStatement_Int()
    {
      Pastry testPastry = new Pastry("test");

      Assert.AreEqual(10, testPastry.CostOfPastry(6));
    }

    [TestMethod]
    public void ReturnCost_GoToElseStatement_Int()
    {
      Pastry testPastry = new Pastry("test");

      Assert.AreEqual(4, testPastry.CostOfPastry(2));
    }

    [TestMethod]
    public void ReturnFreePastries_GoToIfStatement_Int()
    {
      Pastry testPastry = new Pastry("test");

      Assert.AreEqual(2, testPastry.FreePastry(6));
    }

    [TestMethod]
    public void ReturnFreePastry_GoToElseStatement_Int()
    {
      Pastry testPastry = new Pastry("test");

      Assert.AreEqual(0, testPastry.FreePastry(2));
    }
  }
}