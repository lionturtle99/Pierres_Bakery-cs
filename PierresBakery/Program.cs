using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Bakery
  {
    public static void Main()
    { 
      bool orderAgain = true;

      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("I'm Pierre");
      Console.WriteLine("Whats your name?");
      string name = Console.ReadLine();
      Bread bread = new Bread(name);
      Pastry pastry = new Pastry(name);
      Console.WriteLine("Nice to meet you "+bread.Customer+".");
      Console.WriteLine("would you like to order some of my tasty pastries or breads?");
      string answer = Console.ReadLine();
      if (answer.Contains("yes"))
      {

        Bakery.Order(bread, pastry);
        Console.WriteLine("Okay, that'll be $"+bread.Cost+" for the bread, and $"+pastry.Cost+" for the pastries.");
        Console.WriteLine("You got "+bread.Free+" loafs of bread & "+pastry.Free+" pastries for free!");
        while (orderAgain == true)
        {
          Console.WriteLine("");
          Console.WriteLine("Do you want to order more?");
          string orderMore = Console.ReadLine();
          if (orderMore.Contains("no"))
          {
            orderAgain = Goodbye(bread);
          }
          else
          {
            Bakery.Order(bread, pastry);
            Console.WriteLine("Fantastic! Your new price is $"+bread.Cost+" for the bread, and $"+pastry.Cost+" for the pastries.");
            Console.WriteLine("You got "+bread.Free+" loafs of bread & "+pastry.Free+" pastries for free!");
          }
        }
      }
      else if (answer.Contains("no"))
      {
        orderAgain = Goodbye(bread);
      }
      else
      {
        Console.WriteLine("Don't be difficult. It's a simple yes or no answer");
      }
    }
    public static void Order(Bread bread, Pastry pastry)
    {
      Console.WriteLine("Excellent!");
      Console.WriteLine("How many loafs of bread would you like?");
      int loafs = int.Parse(Console.ReadLine());
      Console.WriteLine("and how many pastries would you like?");
      int pastries = int.Parse(Console.ReadLine());

      bread.CostOfBread(loafs);
      bread.FreeBread(loafs);
      pastry.CostOfPastry(pastries);
      pastry.FreePastry(pastries);
    }
    public static bool Goodbye(Bread bread)
    {
      Console.WriteLine("See you next time "+bread.Customer+"!");
      Console.WriteLine("Bye now");
      return false;
    }
  }
}