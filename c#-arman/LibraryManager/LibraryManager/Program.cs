using System;

namespace LibraryManager
{
    class Program
    {
     
        struct Book
        {
            public string Title;
            public string Author;
            public int Year;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Library Book Management ===");

            // Ask how many books
            int count = ReadInt("How many books do you want to enter? ", min: 1);

            Book[] books = new Book[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n-- Enter details for book #{i + 1} --");
                Console.Write("Title: ");
                string title = Console.ReadLine()?.Trim() ?? "";

                Console.Write("Author: ");
                string author = Console.ReadLine()?.Trim() ?? "";

                int year = ReadInt("Year of publication: ", min: 0);

                books[i].Title = title;
                books[i].Author = author;
                books[i].Year = year;
            }

           
            Console.WriteLine("\n=== All books entered ===");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. \"{books[i].Title}\" — {books[i].Author} ({books[i].Year})");
            }

            Console.Write("\nEnter an author name to search for (partial names ok): ");
            string search = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrEmpty(search))
            {
                Console.WriteLine("No search term entered. Program ended.");
            }
            else
            {
                string sLower = search.ToLowerInvariant();
                Console.WriteLine($"\nBooks matching author \"{search}\":");
                bool found = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (!string.IsNullOrEmpty(books[i].Author) &&
                        books[i].Author.ToLowerInvariant().Contains(sLower))
                    {
                        found = true;
                        Console.WriteLine($"- \"{books[i].Title}\" — {books[i].Author} ({books[i].Year})");
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No books found for that author.");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim() ?? "";
                if (int.TryParse(input, out result))
                {
                    if (result >= min && result <= max) return result;
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                }
                else
                {
                    Console.WriteLine("Invalid number. Try again.");
                }
            }
        }
    }
}
