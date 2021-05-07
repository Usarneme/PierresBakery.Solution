using System.Collections.Generic;

namespace PierresBakeryNamespace
{
  public static class PierresBakery
  {

    private static Dictionary<string, int> _currentOrder = new Dictionary<string, int>()
      {
        {"Breads", 0},
        {"Pastries", 0}
      };
    private static int _currentOrderCost = 0;

    public static Dictionary<string, int> GetCurrentOrderItems()
    {
      return _currentOrder;
    }

    public static void ClearOrder()
    {
      _currentOrder = new Dictionary<string, int>()
      {
        {"Breads", 0},
        {"Pastries", 0}
      };
      _currentOrderCost = 0;
    }

    public static int GetCurrentOrderCost()
    {
      UpdateCurrentOrderCost();
      return _currentOrderCost;
    }

    public static void UpdateCurrentOrderCost()
    {
      int numberOfBreads = _currentOrder["Breads"];
      int numberOfPastries = _currentOrder["Pastries"];
      int costOfBreads = Bread.CalculatePrice(numberOfBreads);
      int costOfPastries = Pastry.CalculatePrice(numberOfPastries);
      _currentOrderCost = costOfBreads + costOfPastries;
    }

    public static bool AddToCurrentOrder(string menuItem, int numberOfBreads)
    {
      _currentOrder[menuItem] += numberOfBreads;
      return true;
    }

  }
}
