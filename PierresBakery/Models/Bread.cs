namespace PierresBakery.Models
{
  public class Bread
  {
    public int Cost { set; get; }
    public int Free { set; get; }
    public string Customer { set; get;}

    public Bread(string customer)
    {
      Customer = customer;
      Cost = 0;
      Free = 0;
    }
    public int CostOfBread(int order)
    {
      for (int i=1;i<=order;i++)
      {
        if (i % 3 == 0)
        {
          Cost -= 5;
        }
        Cost+=5;
      }
      return Cost;
    }
    public int FreeBread(int order)
    {
      for (int i=1;i<=order;i++)
      {
        if (i % 3 == 0)
        {
          Free += 1;
        }
      }
      return Free;
    }
  }
}