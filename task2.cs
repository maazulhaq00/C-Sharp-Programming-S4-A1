using System;

class ATM
{
    static void Main()
    {
        Console.Write("Enter your account balance: ");
        double balance = double.Parse(Console.ReadLine());
        int choice;
        double amount;

        while (true)
        {
            Console.WriteLine("\n1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Current Balance: " + balance);
            }
            else if (choice == 2)
            {
                Console.Write("Enter deposit amount: ");
                amount = double.Parse(Console.ReadLine());
                balance += amount;
                Console.WriteLine("Updated Balance: " + balance);
            }
            else if (choice == 3)
            {
                Console.Write("Enter withdrawal amount: ");
                amount = double.Parse(Console.ReadLine());
                if (amount > balance)
                    Console.WriteLine("Insufficient funds.");
                else
                {
                    balance -= amount;
                    Console.WriteLine("Remaining Balance: " + balance);
                }
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
