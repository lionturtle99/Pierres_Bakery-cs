using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int CostOfPastry(int order)
    {
      int cost = 0;
      for (int i=1;i<=order;i++)
      {
        if (i % 3 == 0)
        {
          cost++;
        }
        else
        {
          cost+=2;
        }
      } 
      return cost;
    }
  }
} 