using System.Collections.Generic;

namespace PierresBakeryNamespace
{
  public class PierresBakery : IBakery
  {

    private Dictionary<string, int> _currentOrder;
    private int _currentOrderCost;

    public Dictionary<string, int> GetCurrentOrderItems()
    {
      return _currentOrder;
    }

    public PierresBakery()
    {
      _currentOrderCost = 0;
      _currentOrder = new Dictionary<string, int>()
      {
        {"Breads", 0},
        {"Pastries", 0}
      };
    }

    public void UpdateCurrentOrderCost()
    {
      int numberOfBreads = _currentOrder["Breads"];
      int numberOfPastries = _currentOrder["Pastries"];
      int costOfBreads = Bread.CalculatePrice(numberOfBreads);
      int costOfPastries = Pastry.CalculatePrice(numberOfPastries);
      _currentOrderCost = costOfBreads + costOfPastries;
    }

    public int GetCurrentOrderCost()
    {
      UpdateCurrentOrderCost();
      return _currentOrderCost;
    }

    public bool AddBreadToCurrentOrder(int numberOfBreads)
    {
      _currentOrder["Breads"] += numberOfBreads;
      return true;
    }

    public bool AddPastryToCurrentOrder(int numberOfPastries)
    {
      _currentOrder["Pastries"] += numberOfPastries;
      return true;
    }
  }
}
