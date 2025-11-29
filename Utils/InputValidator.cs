using System;

namespace SimpleBankingSystem.Utils
{
    public static class InputValidator
    {
        public static int GetValidInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if(int.TryParse(input, out int value))
                {
                    return value;
                }
                Console.WriteLine("Invalid Number! Please enter a valid integer.");
            }
        }

        public static double GetValidDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if(double.TryParse(input, out double value))
                {
                    return value;
                }
                Console.WriteLine("Invalid amount! Please enter a valid number.");
            }
        }

        public static string GetNonEmptyString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }
                Console.WriteLine("Input cannot be empty!");
            }
        }

        public static double GetPositiveDouble(string prompt)
        {
            while (true)
            {
                double number = GetValidDouble(prompt);

                if (number > 0)
                    return number;

                Console.WriteLine(" Amount must be greater than zero.");
            }
        }

        public static double GetNonNegativeDouble(string prompt)
        {
            while (true)
            {
                double number = GetValidDouble(prompt);

                if (number >= 0)
                    return number;

                Console.WriteLine(" Amount cannot be negative.");
            }
        }
    }
}