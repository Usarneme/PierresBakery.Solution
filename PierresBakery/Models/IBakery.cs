using System.Collections.Generic;
interface IBakery
{
  List<string> GetCurrentOrder();

  int GetCurrentOrderCost();
}
