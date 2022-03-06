namespace PierresBakery.Models
{
  public class Pastry
  {

    public string Name { set; get; }

    public Pastry(string name)
    {
      Name = name;
    }
    public int CostOfPastry(int order)
    {
      int cost = 0;
      for (int i=1;i<=order;i++)
      {
        if (i % 3 == 0)
        {
          cost--;
        }
        cost+=2;
      } 
      return cost;
    }
  }
} 