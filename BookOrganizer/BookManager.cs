using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookOrganizer
{
    internal class BookManager
    {
        public List<Book> books = new List<Book>();
        
        public BookManager()
        {
            books = new List<Book>();

            Book book1 = new Book("IT", "Stephen", "King");
            books.Add(book1);

            Book book2 = new Book("Alice in Wonderland", "Lewis", "Carol");
            books.Add(book2);

            Book book3 = new Book("Catcher in the Rye", "J.D", "Salinger");
            books.Add(book3);

            Book book4 = new Book("The Wizard of Oz", "L. Frank", "Baum");
            books.Add(book4);

            Book book5 = new Book("Clan of the Cavebear", "Jean M", "Auel");
            books.Add(book5);

            books.Sort((a, b) => a.Title.CompareTo(b.Title));
        }

        public void AddBook(string title, string firstName, string lastName)
        {
            Book book = new Book(title, firstName, lastName);
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public int GetCount()
        {
            return books.Count;
        }
        public void ViewCollection()
        {
            try
            {
                // sort the books alphebetically by title
                books.Sort((a, b) => a.Title.CompareTo(b.Title));

                Console.Clear();
                

                // loop through the list of books and display each one with a number starting at 1
                for (int i = 0; i < books.Count;i++)
                {
                    Console.WriteLine($"{i + 1}. {books[i].Title} by {books[i].AuthorFirstName} {books[i].AuthorLastName}");
                    // old way before learning string interpolation (above)
                    // Console.WriteLine(i + 1 + ". " + books[i].Title + " by " + books[i].AuthorFirstName + " " + books[i].AuthorLastName);
                }
                Console.WriteLine("\n");
                Console.WriteLine("Select the corresponding book # for more options.");
                Console.WriteLine("\n");
            }
            catch
            {
                Console.WriteLine("There was an error trying to view the books.");
            }
        }
        public void ViewBookDetails(int index)
        {
            try
            {
                Console.WriteLine($"Title: {books[index - 1].Title}");
                Console.WriteLine($"Author: {books[index - 1].AuthorFirstName} {books[index - 1].AuthorLastName}");
            }
            catch
            {
                Console.WriteLine("Invalid selection!");
            }
        }
        
    }
}
