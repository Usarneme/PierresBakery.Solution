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
      else if (command.ToLower() == "o")
      {
        int orderCost = PierresBakery.GetCurrentOrderCost();
        Console.WriteLine("\n\tYour total comes to ${0}.00.\n", orderCost);
        OrderUI();
      }
      else if (command.ToLower() == "b")
      {
        BreadOrderUI();
      }
      else if (command.ToLower() == "p")
      {
        PastryOrderUI();
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

    public static void BreadOrderUI()
    {
      Console.Write("\n\tHow many loaves of bread would you like today?\n\t: ");
      string loafString = Console.ReadLine();
      int numberOfLoaves = int.Parse(loafString);
      if (numberOfLoaves == 0)
      {
        Console.WriteLine("\n\tOk, no bread. Returning to main menu.\n");
        OrderUI();
      }
      else
      {
        PierresBakery.AddToCurrentOrder("Breads", numberOfLoaves);
        if (numberOfLoaves == 1)
        {
          Console.WriteLine("\n\tOne loaf of bread added to your order. Returning to the main menu.\n");
          OrderUI();
        }
        else
        {
          Console.WriteLine("\n\t{0} loaves of bread added to your order. Returning to the main menu.\n", numberOfLoaves);
          OrderUI();
        }
      }
    }

    public static void PastryOrderUI()
    {
      Console.Write("\n\tHow many delicious pastries would you like today?\n\t: ");
      string pastriesString = Console.ReadLine();
      int numberOfPastries = int.Parse(pastriesString);
      if (numberOfPastries == 0)
      {
        Console.WriteLine("\n\tOk, no delicious pastries. Returning to main menu.\n");
        OrderUI();
      }
      else
      {
        PierresBakery.AddToCurrentOrder("Pastries", numberOfPastries);
        if (numberOfPastries == 1)
        {
          Console.WriteLine("\n\tOne delicious pastry added to your order. Returning to the main menu.\n");
          OrderUI();
        }
        else
        {
          Console.WriteLine("\n\t{0} delicious pastries added to your order. Returning to the main menu.\n", numberOfPastries);
          OrderUI();
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
