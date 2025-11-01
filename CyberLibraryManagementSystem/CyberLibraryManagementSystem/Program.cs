using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main()
        {
            // Initialize library
            Library library = new Library();

            // Add some sample books
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill", "George Orwell");
            library.AddBook(book1);
            library.AddBook(book2);

            // Search for a book
            List<Book> results = library.SearchBooksByTitle("1984");

            foreach (Book result in results)
            {
                Console.WriteLine($"{result.Title} by {result.Author}");
            }

            // Display all books
            library.DisplayAllBooks();
        }
    }
}
