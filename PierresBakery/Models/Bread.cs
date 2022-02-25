using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int CostOfBread(int order)
    {
      int cost = 0;
      for (int i=1;i<=order;i++)
      {
        cost++;
      } 
      return cost;
    }
  }
} 