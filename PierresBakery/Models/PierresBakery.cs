using System.Collections.Generic;

namespace PierresBakeryNamespace
{
  public class PierresBakery : IBakery
  {
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
