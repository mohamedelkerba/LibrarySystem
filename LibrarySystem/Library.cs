using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentBookCount =0;
        private Book[] BorrowedBooks = new Book[50];
        private int currentBorrowedBookCount = 0;


        public void Display()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.title);
            }
        }

        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book added succefully ");
            }
            else
            {
                Console.WriteLine("Library is Full , can't add new books ");
            }
        }

        public void Remove (Book book)
        {
               int index = Array.IndexOf(books, book);
               books[index] = null;
               currentBookCount--;
            Console.WriteLine("Book Removed");
        }

    }
}
