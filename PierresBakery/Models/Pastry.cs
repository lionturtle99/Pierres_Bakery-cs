namespace PierresBakery.Models
{
  public class Pastry
  {

    public int Cost { set; get; }
    public int Free { set; get; }
    public string Customer { set; get; }

    public Pastry(string customer)
    {
      Customer = customer;
      Cost = 0;
      Free = 0;
    }
        public int CostOfPastry(int order)
    {
      for (int i=1;i<=order;i++)
      {
        if (i % 3 == 0)
        {
          Cost--;
        }
        Cost+=2;
      }
      return Cost;
    }
    public int FreePastry(int order)
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