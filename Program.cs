using System;
using SimpleBankingSystem.Services;
using SimpleBankingSystem.Menus;

namespace SimpleBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankService service = new BankService();

            Console.WriteLine("=================================");
            Console.WriteLine("  Welcome to Simple Bank System  ");
            Console.WriteLine("=================================");

            while (true)
            {
                MenuHandler.DisplayMenu();

                if (!int.TryParse(Console.ReadLine(), out int choice))
                    choice = -1;

                Console.Clear();

                switch (choice)
                {
                    case 1: service.CreateAccount(); break;
                    case 2: service.DepositMoney(); break;
                    case 3: service.WithdrawMoney(); break;
                    case 4: service.CheckBalance(); break;
                    case 5: service.ViewAccountDetails(); break;
                    case 6: service.ListAllAccounts(); break;
                    case 7:
                        Console.WriteLine("Thank you for using Simple Bank System!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
