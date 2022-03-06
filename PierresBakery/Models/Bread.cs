namespace PierresBakery.Models
{
  public class Bread
  {
    public string Name { set; get; }

    public Bread(string name)
    {
      Name = name;
    }
    public int CostOfBread(int order)
    {
      int cost = 0;
      for (int i=1;i<=order;i++)
      {
        if (i % 3 == 0)
        {
          cost -= 5;
        }
        cost+=5;
      }
      return cost;
    }
  }
}