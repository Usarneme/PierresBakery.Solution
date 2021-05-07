using System.Collections.Generic;
interface IBakery
{
  Dictionary<string, int> GetCurrentOrderItems();

  int GetCurrentOrderCost();

  bool AddToCurrentOrder(string item);
}
