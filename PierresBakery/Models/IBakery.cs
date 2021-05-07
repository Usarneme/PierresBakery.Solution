using System.Collections.Generic;
interface IBakery
{
  Dictionary<string, int> GetCurrentOrderItems();

  int GetCurrentOrderCost();

  void UpdateCurrentOrderCost();

  bool AddBreadToCurrentOrder(int numberOfBreads);

  bool AddPastryToCurrentOrder(int numberOfPastries);
}
