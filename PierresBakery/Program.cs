using System.Collections.Generic;
using System.Linq;
using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Bakery
  {
    public static Main()
    {
      Bread breadCost = new Bread();
      int price = 0;

      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Would you like to order some of my tasty pastries or breads?");
      string answer = Console.ReadLine();
      if (answer.Constains("yes"))
      {
        Console.WriteLine("Excellent!");
        Console.WriteLine("How many loafs of bread would you like?");
        int loafs = int.Parse(Console.ReadLine());
        Console.WriteLine("and how many pastries would you like?");
        int pastries = int.Parse(Console.ReadLine());
        breadCost.CostOfBread();
        Console.WriteLine("---------------");
        Console.WriteLine("Fantastic. That'll be $"+price);
        Console.WriteLine("See you next time!");
      }
      else if (answer.Contains("no"));
      


    }
  }
}