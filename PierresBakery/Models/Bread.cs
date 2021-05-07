public class Bread
{

  private static int _singleLoafBreadPrice = 5;
  public static int GetPrice()
  {
    return _singleLoafBreadPrice;
  }

  public static int GetPriceOfMultiple(int numberOfLoaves)
  {
    // deal price is buy 2, get 1 free. every third loaf is free
    int numberOfFreeLoaves = numberOfLoaves / 3;
    int numberOfPaidLoaves = numberOfLoaves - numberOfFreeLoaves;
    return _singleLoafBreadPrice * numberOfPaidLoaves;
  }
}
