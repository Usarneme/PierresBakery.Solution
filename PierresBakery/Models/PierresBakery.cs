using System.Collections.Generic;

namespace PierresBakeryNamespace
{
  public class PierresBakery : IBakery
  {

    private List<string> _currentOrder = new List<string>();
    private int _currentOrderCost = 0;

    public List<string> GetCurrentOrder()
    {
      return new List<string>();
    }

    public int GetCurrentOrderCost()
    {
      return 0;
    }
  }
}
