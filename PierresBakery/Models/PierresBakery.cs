using System.Collections.Generic;

namespace PierresBakeryNamespace
{
  public class PierresBakery : IBakery
  {

    private Dictionary<string, int> _currentOrder = new Dictionary<string, int>()
    {
      {"Breads", 0},
      {"Pastries", 0}
    };
    private int _currentOrderCost = 0;

    public Dictionary<string, int> GetCurrentOrderItems()
    {
      return _currentOrder;
    }

    public int GetCurrentOrderCost()
    {
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
