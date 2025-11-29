using System;
using SimpleBankingSystem.Services;

namespace SimpleBankingSystem.Menus
{
    public static class MenuHandler
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("\n--- Bank Menu ---");
            Console.WriteLine("1.Create Account");
            Console.WriteLine("2.Deposit Money");
            Console.WriteLine("3.Withdraw Money");
            Console.WriteLine("4.Check Balance");
            Console.WriteLine("5.View Account Details");
            Console.WriteLine("6.List all Accounts");
            Console.WriteLine("7.Exit");
            Console.WriteLine("Enter your choice (1-7): ");
        }
    }
}