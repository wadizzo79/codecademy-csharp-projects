using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Library
    {
        private List<Book> books = new List<Book>();

        // Adds a new book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> SearchBooksByTitle(string title)
        {
            List<Book> matchingBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Title.Contains(title))
                {
                    matchingBooks.Add(book);
                }
            }

            return matchingBooks;
        }

        public void DisplayAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }
    }
}