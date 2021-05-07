public class Pastry
{

  private static int _singlePastryPrice = 2;
  public static int GetPrice()
  {
    return _singlePastryPrice;
  }

  public static int GetPriceOfMultiple(int numberOfPastries)
  {
    // 1 for $2, 3 for $5
    // 1,2,3,4,5,6, 7, 8, 9, 10
    // 2,4,5,7,9,10,12,14,15,17
    int numberAtDealPrice = numberOfPastries / 3;
    int numberAtFullprice = numberOfPastries % 3;
    int totalCost = (numberAtDealPrice * 5) + (numberAtFullprice * 2);
    return totalCost;
  }
}
