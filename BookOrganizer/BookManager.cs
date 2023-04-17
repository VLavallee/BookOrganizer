using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookOrganizer
{
    public class BookManager
    {
        public List<Book> books = new List<Book>();
        
        public BookManager()
        {
            books = new List<Book>();

            Book book1 = new Book("IT", "Stephen", "King", "Horror", "Thriller", 1138, 1986, true, 1, 7.5, 12.95);
            books.Add(book1);

            Book book2 = new Book("Alice's Adventures in Wonderland", "Lewis", "Carol", "Children's literature", "Fantasy", 101, 1865, false, true, 7.35);
            books.Add(book2);

            Book book3 = new Book("Catcher in the Rye", "J.D", "Salinger", "Bildungsroman", "Young adult fiction", 234, 1951, false, false, 12.99);
            books.Add(book3);

            Book book4 = new Book("The Wonderful Wizard of Oz", "L. Frank", "Baum", "Children's literature", "Fantasy fiction", 254, 1900, false, true, 40.88);
            books.Add(book4);

            Book book5 = new Book("Clan of the Cavebear", "Jean M", "Auel", "Historical fiction", "Prehistoric fiction", 554, 1980, true, 1, 9.0, 9.99);
            books.Add(book5);

            books.Sort((a, b) => a.Title.CompareTo(b.Title));
        }

        public void AddBook(string title, string firstName, string lastName)
        {
            Book book = new Book(title, firstName, lastName);
            books.Add(book);
        }
        public bool SearchByTitle(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    return true;
                }
            }
            return false;
        }
        public void RemoveBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    books.RemoveAt(i);
                    break;
                }
            }
        }
        public void RemoveAllBooks()
        {
            books.Clear();
        }
        public int GetCount()
        {
            return books.Count;
        }
        public int GetToBeReadCount()
        {
            int toBeRead = 0;
            foreach (Book book in books)
            {
                if(book.ToBeRead == true)
                {
                    toBeRead++;
                }
            }
            return toBeRead;
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
                Console.WriteLine("\n");
                Console.WriteLine($"Description: {books[index - 1].Description}");
                Console.WriteLine($"Genre: {books[index - 1].Genre}");
                Console.WriteLine($"Subgenre: {books[index - 1].Subgenre}");

                if (books[index - 1].Year == 0) { Console.WriteLine($"Year: {Book.notEntered}"); } else { Console.WriteLine($"Year: {books[index - 1].Year}"); }
                if (books[index - 1].PageLength == 0) { Console.WriteLine($"Page Length: {Book.notEntered}"); } else { Console.WriteLine($"Page length: {books[index - 1].PageLength} pages"); }
                if (books[index - 1].Rating == 0) { Console.WriteLine($"Rating: {Book.notEntered}"); } else { Console.WriteLine($"Rating: {books[index - 1].Rating}"); }
                if (books[index - 1].HasBeenRead == false) { Console.WriteLine($"Has been read? {Book.notEntered}"); } else { Console.WriteLine($"Has been read? {books[index - 1].HasBeenRead}"); }
                if (books[index - 1].TimesRead == 0) { Console.WriteLine($"Times read: {Book.notEntered}"); } else { Console.WriteLine($"Times read: {books[index - 1].TimesRead}"); }
                if (books[index - 1].Price == 0) { Console.WriteLine($"Price: {Book.notEntered}"); } else { Console.WriteLine($"Price: {books[index - 1].Price}"); }
            }
            catch
            {
                Console.WriteLine("Invalid selection!");
            }
        }
        
        
    }
}
