using System;
using PierresBakeryNamespace;

namespace ProgramNamespace
{
  class Program
  {

    private PierresBakery _pierresBakeryInstance = new PierresBakery();
    private static bool _isOrdering = true;

    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine("\t\n\n\tWelcome to Pierre's Bakery!");
      Console.WriteLine("\t\"For all your fresh bread and pastry needs. Radiation free since 1906!\" -Pierre Curie, Proprietor\n\n");
      ShowMenu();
      while (_isOrdering == true)
      {
        OrderUI();
      }
    }

    public static void ShowMenu()
    {
      Console.WriteLine("\tMenu\t\tPrice\t\t\tToday's Specials");
      Console.WriteLine("\t----\t\t-----\t\t\t----------------");
      Console.WriteLine("\tLoaf of Bread\t$5\t\t\tBuy Two (2) Loaves And Get One (1) Free!");
      Console.WriteLine("\tHot Pastry\t$2\t\t\tThree (3) Pastries For $5!\n\n");
    }

    public static void OrderUI()
    {
      Console.WriteLine("\tOptions: [M]enu. [I]tems Ordered. [O]rder Cost Total.");
      Console.Write("\tPlease make a selection. Order [B]read or [P]astry\n\t: ");
      string order = Console.ReadLine();
      if (order.ToLower() == "m")
      {
        ShowMenu();
        OrderUI();
      }
      else if (order.ToLower() == "o")
      {
        // int orderCost = _pierresBakeryInstance.GetCurrentOrderCost();
      }
      _isOrdering = false;
    }
  }
}
