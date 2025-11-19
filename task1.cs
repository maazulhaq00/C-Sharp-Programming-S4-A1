using System;

class Library
{
    static void Main()
    {
        Console.Write("How many books do you want to enter? ");
        int n = int.Parse(Console.ReadLine());

        string[] titles = new string[n];
        string[] authors = new string[n];
        int[] years = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("\nEnter title: ");
            titles[i] = Console.ReadLine();

            Console.Write("Enter author: ");
            authors[i] = Console.ReadLine();

            Console.Write("Enter year: ");
            years[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Book List ---");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i + 1}. {titles[i]} | {authors[i]} | {years[i]}");
        }

        Console.Write("\nEnter author name to search: ");
        string searchAuthor = Console.ReadLine();
        bool found = false;

        Console.WriteLine("\n--- Search Results ---");
        for (int i = 0; i < n; i++)
        {
            if (authors[i] == searchAuthor)
            {
                Console.WriteLine($"{titles[i]} | {authors[i]} | {years[i]}");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No books found by this author.");
    }
}
