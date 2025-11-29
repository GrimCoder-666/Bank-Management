using System;

namespace SimpleBankingSystem.Models
{
    public class BankAccount
    {
        private int accountNumber;
        private string accountHolderName;
        private double balance;
        private string accountType;

        public BankAccount(int accNum, string name, double initialBalance, string type)
        {
            accountNumber = accNum;
            accountHolderName = name;
            balance = initialBalance;
            accountType = type;
        }

        public int AccountNumber => accountNumber;
        public string AccountHolderName
        {
            get => accountHolderName;
            set => accountHolderName = value;
        }

        public double Balance => balance;
        public string AccountType => accountType;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited ${amount:F2}");
                Console.WriteLine($"New Balance: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }

        public bool Withdraw(double amount)
        {
            if (amount<=0)
            {
                Console.WriteLine("Withdrawal amount must be positive!");
                return false;
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient Funds!");
                Console.WriteLine($"Current Balance: ${balance:F2}");
                return false;
            }

            balance -= amount;
            Console.WriteLine($"Successfully withdrawn ${amount:F2}");
            Console.WriteLine($"New Balance: ${balance:F2}");
            return true;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolderName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Account Balance: ${balance:F2}");
            Console.WriteLine("------------------------");
        }
    }
}