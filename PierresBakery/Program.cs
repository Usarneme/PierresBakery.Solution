using PierresBakeryNamespace;
using System;
using System.Collections.Generic;

namespace ProgramNamespace
{
  public class Program
  {
    private static bool _isOrdering = true;

    public static void Main()
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

    public static void ShowOptions()
    {
      Console.WriteLine("\tOptions: View [M]enu. View [I]tems Ordered. View [O]rder Cost Total. Order [B]read. Order [P]astry. [C]heckout. [E]xit.");
    }

    public static void OrderUI()
    {
      ShowOptions();
      Console.Write("\tPlease make a selection.\n\t: ");
      string command = Console.ReadLine();
      if (command.ToLower() == "m")
      {
        ShowMenu();
        OrderUI();
      }
      else if (command.ToLower() == "i")
      {
        Dictionary<string, int> itemsOrdered = PierresBakery.GetCurrentOrderItems();
        int numberOfBreads = itemsOrdered["Breads"];
        int numberOfPastries = itemsOrdered["Pastries"];
        if (numberOfBreads > 0 || numberOfPastries > 0)
        {
          Console.WriteLine("\n\tYou have ordered:");
          if (numberOfBreads == 1)
          {
            Console.Write("\t{0} loaf of bread. ");
          }
          else
          {
            Console.Write("\t{0} loaves of bread. ");
          }
          if (numberOfPastries == 1)
          {
            Console.Write("\t{0} delicious pastry. ");
          }
          else
          {
            Console.Write("\t{0} delicious pastries. ");
          }
        }
        else
        {
          Console.WriteLine("\n\tYou haven't ordered anything yet!\n");
        }
        OrderUI();
      }
      else if (command.ToLower() == "o")
      {
        int orderCost = PierresBakery.GetCurrentOrderCost();
        Console.WriteLine("\n\tYour total comes to ${0}.00.\n", orderCost);
        OrderUI();
      }
      else if (command.ToLower() == "e")
      {
        Console.WriteLine("\n\n\tThanks for stopping by. We hope to see you again soon!\n\n");
        _isOrdering = false;
      }
      else
      {
        Console.WriteLine("\n\tI didn't understand that command. Please try again.\n");
        OrderUI();
      }
    }

    public static void BreadOrderUI()
    {
      ShowOptions();
      Console.WriteLine("\n\tHow many loaves of bread would you like today?\n\t: ");
      int numberOfLoaves = Console.Read();
    }
  }
}
