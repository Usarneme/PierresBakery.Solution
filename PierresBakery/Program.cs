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
      Console.WriteLine("\tMenu\t\t\tPrice\t\t\tToday's Specials");
      Console.WriteLine("\t----\t\t\t-----\t\t\t----------------");
      Console.WriteLine("\tLoaf of Bread\t\t$5\t\t\tBuy Two (2) Loaves And Get One (1) Free!");
      Console.WriteLine("\tDelicious Pastry\t$2\t\t\tThree (3) Pastries For $5!\n\n");
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
      if (command.ToLower() == "m" || command.ToLower() == "menu")
      {
        ShowMenu();
        OrderUI();
      }
      else if (command.ToLower() == "i" || command.ToLower() == "items" || command.ToLower() == "order")
      {
        Dictionary<string, int> itemsOrdered = PierresBakery.GetCurrentOrderItems();
        int numberOfBreads = itemsOrdered["Breads"];
        int numberOfPastries = itemsOrdered["Pastries"];
        if (numberOfBreads > 0 || numberOfPastries > 0)
        {
          Console.WriteLine("\n\tYou have ordered:");
          if (numberOfBreads == 1)
          {
            Console.Write("\t{0} loaf of bread. ", numberOfBreads);
          }
          else
          {
            Console.Write("\t{0} loaves of bread. ", numberOfBreads);
          }
          if (numberOfPastries == 1)
          {
            Console.Write("\n\t{0} delicious pastry. ", numberOfPastries);
          }
          else
          {
            Console.Write("\n\t{0} delicious pastries. ", numberOfPastries);
          }
          Console.WriteLine("\n");
        }
        else
        {
          Console.WriteLine("\n\tYou haven't ordered anything yet!\n");
        }
        OrderUI();
      }
      else if (command.ToLower() == "o" || command.ToLower() == "cost" || command.ToLower() == "price")
      {
        int orderCost = PierresBakery.GetCurrentOrderCost();
        Console.WriteLine("\n\tYour total comes to ${0}.00.\n", orderCost);
        OrderUI();
      }
      else if (command.ToLower() == "b" || command.ToLower() == "bread" || command.ToLower() == "breads")
      {
        OrderUI("Breads");
      }
      else if (command.ToLower() == "p" || command.ToLower() == "pastry" || command.ToLower() == "pastries")
      {
        OrderUI("Pastries");
      }
      else if (command.ToLower() == "c")
      {
        CheckoutUI();
        _isOrdering = false;
      }
      else if (command.ToLower() == "e")
      {
        Console.WriteLine("\n\n\tCancelling your order.\n\tThanks for stopping by. We hope to see you again soon!\n\n");
        _isOrdering = false;
      }
      else
      {
        Console.WriteLine("\n\tI didn't understand that command. Please try again.\n");
        OrderUI();
      }
    }

    public static void OrderUI(string itemName)
    {
      string singleItemName;
      string pluralItemName;
      if (itemName == "Breads")
      {
        singleItemName = "loaf bread";
        pluralItemName = "loaves of bread";
      }
      else
      {
        singleItemName = "delicious pastry";
        pluralItemName = "delicious pastries";
      }
      Console.Write("\n\tHow many {0} would you like today?\n\t: ", pluralItemName);
      string itemInputString = Console.ReadLine();
      if (string.IsNullOrEmpty(itemInputString))
      {
        Console.WriteLine("\tYou forgot to input a number. If you don't want any more {0} enter 0.", pluralItemName);
        OrderUI(itemName);
      }
      else
      {
        int numberOfItems;
        bool parseSuccess = int.TryParse(itemInputString, out numberOfItems);
        if (!parseSuccess)
        {
          Console.WriteLine("\tThat is not a valid number. Please try again.");
          OrderUI(itemName);
        }
        else
        {
          if (numberOfItems == 0)
          {
            Console.WriteLine("\n\tOk, no {0}. Returning to main menu.\n", pluralItemName);
            OrderUI();
          }
          else
          {
            PierresBakery.AddToCurrentOrder(itemName, numberOfItems);
            if (numberOfItems == 1)
            {
              Console.WriteLine("\n\tOne {0} added to your order. Returning to the main menu.\n", singleItemName);
              OrderUI();
            }
            else
            {
              Console.WriteLine("\n\t{0} {1} added to your order. Returning to the main menu.\n", numberOfItems, pluralItemName);
              OrderUI();
            }
          }
        }
      }
    }

    public static void CheckoutUI()
    {
      Dictionary<string, int> itemsOrdered = PierresBakery.GetCurrentOrderItems();
      int numberOfBreads = itemsOrdered["Breads"];
      int numberOfPastries = itemsOrdered["Pastries"];
      if (numberOfBreads > 0 || numberOfPastries > 0)
      {
        int orderCost = PierresBakery.GetCurrentOrderCost();
        Console.WriteLine("\n\tThanks for visiting us today! ");
        Console.WriteLine("\tYour total comes to ${0}.00.", orderCost);
        Console.WriteLine("\tPlease enter your credit card number and we'll process your payment.\n\n ;)");
      }
      else
      {
        Console.WriteLine("\n\n\tOh no! You forgot to order anything. Maybe next time... Have a good day!\n\n");
      }
    }
  }
}
