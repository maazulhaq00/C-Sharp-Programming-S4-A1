using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Assignment Menu ");
                Console.WriteLine("1. Library Book Management");
                Console.WriteLine("2. ATM Cash Withdrawal Simulation");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice (1-3): ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    LibraryManagement();
                }
                else if (choice == "2")
                {
                    ATMSimulation();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting Program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Press any key...");
                    Console.ReadKey();
                }
            }
        }

        static void LibraryManagement()
        {
            Console.Clear();
            Console.Write("How many books do you want to enter? ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid number! Returning to menu...");
                Console.ReadKey();
                return;
            }

            string[] titles = new string[n];
            string[] authors = new string[n];
            int[] years = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Book {i + 1} ---");

                Console.Write("Enter Title: ");
                titles[i] = Console.ReadLine();

                Console.Write("Enter Author: ");
                authors[i] = Console.ReadLine();

                Console.Write("Enter Year of Publication: ");
                while (!int.TryParse(Console.ReadLine(), out years[i]))
                {
                    Console.Write("Enter valid year: ");
                }
            }

            Console.WriteLine("\n===== Books Entered =====");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. \"{titles[i]}\" by {authors[i]} ({years[i]})");
            }

            Console.Write("\nEnter Author name to search: ");
            string search = Console.ReadLine();

            Console.WriteLine("\n===== Search Results =====");
            bool found = false;

            for (int i = 0; i < n; i++)
            {
                if (authors[i].ToLower().Contains(search.ToLower()))
                {
                    Console.WriteLine($"- \"{titles[i]}\" ({years[i]})");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found for this author.");

            Console.WriteLine("\nPress any key to return to main menu...");
            Console.ReadKey();
        }

        static void ATMSimulation()
        {
            Console.Clear();
            Console.Write("Enter account balance: ");

            if (!double.TryParse(Console.ReadLine(), out double balance) || balance < 0)
            {
                Console.WriteLine("Invalid balance! Returning to menu...");
                Console.ReadKey();
                return;
            }

            while (true)
            {
                Console.WriteLine("\n----- ATM Menu -----");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine($"Your Balance: {balance}");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter amount to deposit: ");
                    if (double.TryParse(Console.ReadLine(), out double deposit) && deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine($"Deposit successful! Updated Balance: {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount!");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Enter amount to withdraw: ");
                    if (double.TryParse(Console.ReadLine(), out double withdraw) && withdraw > 0)
                    {
                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine($"Withdrawal successful! Remaining Balance: {balance}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount!");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Returning to Main Menu...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }

            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }
    }
}
