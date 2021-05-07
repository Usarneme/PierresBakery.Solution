using System.Collections.Generic;
interface IBakery
{
  Dictionary<string, int> GetCurrentOrderItems();

  int GetCurrentOrderCost();

  void UpdateCurrentOrderCost();

  bool AddToCurrentOrder(string orderName, int numberOfBreads);
}
