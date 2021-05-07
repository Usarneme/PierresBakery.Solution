public class Pastry
{
  private static int _singlePastryPrice = 2;
  public static int Price
  {
    get { return _singlePastryPrice; }
  }

  public static int GetPriceOfMultiple(int numberOfPastries)
  {
    // deal price is 1 for $2, 3 for $5
    int numberAtDealPrice = numberOfPastries / 3;
    int numberAtFullprice = numberOfPastries % 3;
    int totalCost = (numberAtDealPrice * 5) + (numberAtFullprice * 2);
    return totalCost;
  }
}
