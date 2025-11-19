using System;

namespace ATMSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple ATM Simulator ===");
            decimal balance = ReadDecimal("Enter your current account balance: ", min: 0m);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose a transaction:");
                Console.WriteLine("1) Check Balance");
                Console.WriteLine("2) Deposit");
                Console.WriteLine("3) Withdraw");
                Console.WriteLine("4) Exit");

                int choice = ReadInt("Enter choice (1-4): ", 1, 4);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is: {balance:C}");
                        break;

                    case 2:
                        decimal deposit = ReadDecimal("Enter deposit amount: ", min: 0.01m);
                        balance += deposit;
                        Console.WriteLine($"Deposit successful. New balance: {balance:C}");
                        break;

                    case 3:
                        decimal withdraw = ReadDecimal("Enter amount to withdraw: ", min: 0.01m);
                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine($"Please take your cash. Remaining balance: {balance:C}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank you. Exiting...");
                        running = false;
                        break;
                }
            }

            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }

        static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim() ?? "";
                if (int.TryParse(input, out result) && result >= min && result <= max)
                    return result;
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        static decimal ReadDecimal(string prompt, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
        {
            decimal result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim() ?? "";
                if (decimal.TryParse(input, out result) && result >= min && result <= max)
                    return result;
                Console.WriteLine("Invalid amount. Try again.");
            }
        }
    }
}
