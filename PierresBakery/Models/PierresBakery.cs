using System.Collections.Generic;

namespace PierresBakeryNamespace
{
  public class PierresBakery : IBakery
  {

    private List<Bread> _currentBreadOrder = new List<Bread>();
    private List<Pastry> _currentPastryOrder = new List<Pastry>();
    private int _currentOrderCost = 0;

    public List<string> GetCurrentOrderItems()
    {
      return new List<string>();
    }

    public int GetCurrentOrderCost()
    {
      return -1;
    }

    public bool AddToCurrentOrder(string item)
    {
      return true;
    }
  }
}
