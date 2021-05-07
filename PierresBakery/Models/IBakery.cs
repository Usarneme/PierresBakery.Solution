using System.Collections.Generic;
interface IBakery
{
  Dictionary<string, int> GetCurrentOrderItems();

  int GetCurrentOrderCost();

  bool AddBreadToCurrentOrder(int numberOfBreads);

  bool AddPastryToCurrentOrder(int numberOfPastries);
}
