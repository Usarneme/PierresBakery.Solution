using System.Collections.Generic;

namespace PierresBakeryNamespace
{
  public class PierresBakery : IBakery
  {

    private Dictionary<string, int> _currentOrder;
    private int _currentOrderCost;

    public PierresBakery()
    {
      _currentOrderCost = 0;
      _currentOrder = new Dictionary<string, int>()
      {
        {"Breads", 0},
        {"Pastries", 0}
      };
    }

    public Dictionary<string, int> GetCurrentOrderItems()
    {
      return _currentOrder;
    }


    public int GetCurrentOrderCost()
    {
      UpdateCurrentOrderCost();
      return _currentOrderCost;
    }

    public void UpdateCurrentOrderCost()
    {
      int numberOfBreads = _currentOrder["Breads"];
      int numberOfPastries = _currentOrder["Pastries"];
      int costOfBreads = Bread.CalculatePrice(numberOfBreads);
      int costOfPastries = Pastry.CalculatePrice(numberOfPastries);
      _currentOrderCost = costOfBreads + costOfPastries;
    }

    public bool AddToCurrentOrder(string menuItem, int numberOfBreads)
    {
      _currentOrder[menuItem] += numberOfBreads;
      return true;
    }

  }
}
