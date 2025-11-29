using System;
using SimpleBankingSystem.Models;
using SimpleBankingSystem.Utils;

namespace SimpleBankingSystem.Services
{
    public class BankService
    {
        private BankAccount[] accounts = new BankAccount[100];
        private int accountCount = 0;

        public BankAccount FindAccount(int accountNumber)
        {
            for (int i = 0; i < accountCount; i++)
                if (accounts[i].AccountNumber == accountNumber)
                    return accounts[i];

            return null;
        }

        public void CreateAccount()
        {
            if (accountCount >= accounts.Length)
            {
                Console.WriteLine("Maximum number of accounts reached!");
                return;
            }

            Console.WriteLine("\n--- Create New Account ---");

            string name = InputValidator.GetNonEmptyString("Enter account holder name: ");
            string type = InputValidator.GetNonEmptyString("Enter account type (Savings/Checking): ");
            double initialBalance = InputValidator.GetNonNegativeDouble("Enter initial deposit amount: $");

            int accountNumber = 1001 + accountCount;

            accounts[accountCount++] = new BankAccount(accountNumber, name, initialBalance, type);

            Console.WriteLine("\nAccount created successfully!");
            Console.WriteLine($"Account Number: {accountNumber}");
        }

        public void DepositMoney()
        {
            Console.WriteLine("\n--- Deposit Money ---");

            int accNum = InputValidator.GetValidInt("Enter account number: ");
            BankAccount account = FindAccount(accNum);

            if (account == null)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            double amount = InputValidator.GetPositiveDouble("Enter deposit amount: $");
            account.Deposit(amount);
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("\n--- Withdraw Money ---");

            int accNum = InputValidator.GetValidInt("Enter account number: ");
            BankAccount account = FindAccount(accNum);

            if (account == null)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            double amount = InputValidator.GetPositiveDouble("Enter withdrawal amount: $");
            account.Withdraw(amount);
        }

        public void CheckBalance()
        {
            Console.WriteLine("\n--- Check Balance ---");

            int accNum = InputValidator.GetValidInt("Enter account number: ");
            BankAccount account = FindAccount(accNum);

            if (account != null)
                Console.WriteLine($"Current Balance: ${account.Balance:F2}");
            else
                Console.WriteLine("Account not found!");
        }

        public void ListAllAccounts()
        {
            Console.WriteLine("\n--- All Accounts ---");

            if (accountCount == 0)
            {
                Console.WriteLine("No accounts found!");
                return;
            }

            Console.WriteLine($"{"Account#",-10} {"Name",-20} {"Type",-10} {"Balance",-10}");
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < accountCount; i++)
            {
                var a = accounts[i];
                Console.WriteLine($"{a.AccountNumber,-10} {a.AccountHolderName,-20} {a.AccountType,-10} ${a.Balance,-10:F2}");
            }
        }

        public void ViewAccountDetails()
        {
            Console.WriteLine("\n--- View Account Details ---");

            int accNum = InputValidator.GetValidInt("Enter account number: ");
            BankAccount account = FindAccount(accNum);

            if (account != null)
                account.DisplayAccountDetails();
            else
                Console.WriteLine("Account not found!");
        }
    }
}
