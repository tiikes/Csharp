namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    public class TextInterface
    {
        // Create the userinterface here
        private List<Book> books;

        public TextInterface()
        {
            this.books = new List<Book>();
        }

        public void Start()
        {
            Console.WriteLine("Input the name of the book, empty stops:");
            string inputName;

            while (!string.IsNullOrWhiteSpace(inputName = Console.ReadLine()))
            {
                Console.WriteLine("Input the age recommendation:");
                if (int.TryParse(Console.ReadLine(), out int inputAge))
                {
                    Book newBook = new Book(inputName, inputAge);
                    books.Add(newBook);
                }
                else
                {
                    Console.WriteLine("Invalid age recommendation. Please enter a valid number.");
                }

                Console.WriteLine("Input the name of the book, empty stops:");
            }

            Console.WriteLine($"{books.Count} books in total.");
            Console.WriteLine("\nBooks:");

            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
            books.Sort();

            Console.WriteLine($"{books.Count} books in total.");
            Console.WriteLine("\nBooks:");

            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

    }
}