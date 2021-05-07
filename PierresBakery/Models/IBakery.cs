using System.Collections.Generic;
interface IBakery
{
  List<string> GetCurrentOrderItems();

  int GetCurrentOrderCost();

  bool AddToCurrentOrder(string item);
}
