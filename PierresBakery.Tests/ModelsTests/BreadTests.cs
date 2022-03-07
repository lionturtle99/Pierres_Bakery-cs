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
    public void GetCustomer_ReturnsCustomer_String()
    {
      string customer = "john";

      Bread testBread = new Bread(customer);
      string result = testBread.Customer;

      Assert.AreEqual(customer, result);
    }

    [TestMethod]
    public void SetCustomer_SetCustomer_String()
    {
      string customer = "Kylo";
      Bread testBread = new Bread(customer);

      string updatedCustomer = "Peter";
      testBread.Customer = updatedCustomer;
      string result = testBread.Customer;

      Assert.AreEqual(updatedCustomer, result);
    }

    [TestMethod]
    public void ReturnCost_GoToIfStatement_Int()
    {
      Bread testBread = new Bread("test");

      Assert.AreEqual(20, testBread.CostOfBread(6));
    }

    [TestMethod]
    public void ReturnCost_GoToElseStatement_Int()
    {
      Bread testBread = new Bread("test");

      Assert.AreEqual(5, testBread.CostOfBread(1));
    }

    [TestMethod]
    public void ReturnFreeBread_GoToIfStatement_Int()
    {
      Bread testBread = new Bread("test");

      Assert.AreEqual(1, testBread.FreeBread(3));
    }

    [TestMethod]
    public void ReturnFreeBread_GoToElseStatement_Int()
    {
      Bread testBread = new Bread("test");

      Assert.AreEqual(0, testBread.FreeBread(1));
    }
  }
}