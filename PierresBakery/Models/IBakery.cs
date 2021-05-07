using System.Collections.Generic;
interface IBakery
{
  Dictionary<string, int> GetCurrentOrderItems();

  int GetCurrentOrderCost();

  bool AddBreadToCurrentOrder(Bread bread);

  bool AddPastryToCurrentOrder(Pastry pastry);
}
