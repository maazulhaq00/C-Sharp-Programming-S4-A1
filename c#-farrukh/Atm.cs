using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class Atm
    {
       public static void Run()
        {
            Console.Write("Enter your account balance: ");
            double balance = double.Parse(Console.ReadLine());

            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("\n===== ATM Menu =====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                choice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (choice == 1)
                {
                    Console.WriteLine($"Your balance is: {balance}");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine($"Deposit successful! Updated balance: {balance}");
                }
                else if (choice == 3)
                {
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());

                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.WriteLine($"Withdrawal successful! Remaining balance: {balance}");
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thank you for using ATM. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }
    }
}
