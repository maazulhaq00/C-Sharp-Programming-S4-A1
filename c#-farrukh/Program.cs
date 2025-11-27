//namespace Assignment
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}




namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atm.Run();

            //Console.Write("How many books do you want to enter? ");
            //int totalBooks = int.Parse(Console.ReadLine());

            //// Arrays to store data
            //string[] titles = new string[totalBooks];
            //string[] authors = new string[totalBooks];
            //int[] years = new int[totalBooks];

            //// Input Section
            //for (int i = 0; i < totalBooks; i++)
            //{
            //    Console.WriteLine($"\n--- Enter details for Book {i + 1} ---");

            //    Console.Write("Title: ");
            //    titles[i] = Console.ReadLine();

            //    Console.Write("Author: ");
            //    authors[i] = Console.ReadLine();

            //    Console.Write("Year of Publication: ");
            //    years[i] = int.Parse(Console.ReadLine());
            //}

            //// Display All Books
            //Console.WriteLine("\n\n===== All Books Entered =====");
            //for (int i = 0; i < totalBooks; i++)
            //{
            //    Console.WriteLine($"\nBook {i + 1}");
            //    Console.WriteLine($"Title: {titles[i]}");
            //    Console.WriteLine($"Author: {authors[i]}");
            //    Console.WriteLine($"Year: {years[i]}");
            //}

            //// Search by Author
            //Console.Write("\nEnter author name to search: ");
            //string searchAuthor = Console.ReadLine();

            //Console.WriteLine("\n===== Search Results =====");
            //bool found = false;

            //for (int i = 0; i < totalBooks; i++)
            //{
            //    if (authors[i].Equals(searchAuthor, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"\nTitle: {titles[i]}");
            //        Console.WriteLine($"Author: {authors[i]}");
            //        Console.WriteLine($"Year: {years[i]}");
            //        found = true;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("No books found for this author.");
            //}
        }
    }
}

