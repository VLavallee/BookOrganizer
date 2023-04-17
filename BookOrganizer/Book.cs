using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrganizer
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Subgenre { get; set; }
        public int PageLength { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public bool HasBeenRead { get; set; }
        public bool ToBeRead { get; set; }
        public int TimesRead { get; set; }

        public const string notEntered = "--";
        
        public Book (string title)
        {
            Title = title;
        }
        public Book (string title, string authorFirstName, string authorLastName)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            Description = notEntered;
            Genre = notEntered;
            Subgenre = notEntered;
        }
        public Book (string title, string authorFirstName, string authorLastName, string genre)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            Genre = genre;
            Description = notEntered;
            Subgenre = notEntered;
        }
        public Book(string title, string authorFirstName, string authorLastName, string genre, string subGenre, int pageLength, int year, bool hasBeenRead, bool toBeRead, double price)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            Description = notEntered;
            Genre = genre;
            Subgenre = subGenre;
            PageLength = pageLength;
            Year = year;
            HasBeenRead = hasBeenRead;
            ToBeRead = toBeRead;
            TimesRead = 0;
            Price = price;
        }
        public Book (string title, string authorFirstName, string authorLastName, string genre, string subGenre, int pageLength, int year, bool hasBeenRead, int timesRead, double rating, double price)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            Description= notEntered;
            Genre = genre;
            Subgenre = subGenre;
            PageLength = pageLength;
            Year = year;
            HasBeenRead = hasBeenRead;
            TimesRead = timesRead;
            Rating = rating;
            Price = price;
        }
        public void ReadBook()
        {
            HasBeenRead = true;
            TimesRead++;
        }
    }
}
