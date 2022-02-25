using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Bakery
  {
    public static void Main()
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      bool boolean = true;

      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Would you like to order some of my tasty pastries or breads?");
      string answer = Console.ReadLine();
      if (answer.Contains("yes"))
      {
        while (boolean == true)
        {
          Console.WriteLine("Excellent!");
          Console.WriteLine("How many loafs of bread would you like?");
          int loafs = int.Parse(Console.ReadLine());
          Console.WriteLine("and how many pastries would you like?");
          int pastries = int.Parse(Console.ReadLine());
          int breadCost = bread.CostOfBread(loafs);
          int pastryCost = pastry.CostOfPastry(pastries);
          Console.WriteLine("Fantastic. That'll be $"+breadCost+" for the bread, and $"+pastryCost+" for the pastries");
          Console.WriteLine("");
          Console.WriteLine("Do you want to order more?");
          string orderAgain = Console.ReadLine();
          if (orderAgain.Contains("no"))
          {
            Console.WriteLine("Ok see you next time");
            Console.WriteLine("Bye now!");
            boolean = false;
          }
        }
      }
      else if (answer.Contains("no"))
      {
        Console.WriteLine("Ok see you next time!");
        Console.WriteLine("Bye now");
        boolean = false;
      }
      else
      {
        Console.WriteLine("Don't be difficult. It's a yes or no answer");
      }
    }
  }
}