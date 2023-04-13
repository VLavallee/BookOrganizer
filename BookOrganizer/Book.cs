using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrganizer
{
    internal class Book
    {
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public string PageLength { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public bool HasBeenRead { get; set; }
        public int TimesRead { get; set; }
        
        public Book (string title)
        {
            Title = title;
        }
        public Book (string title, string authorFirstName, string authorLastName)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
        }
        public Book (string title, string authorFirstName, string authorLastName, string genre)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            Genre = genre;
        }
        public Book (string title, string authorFirstName, string authorLastName, string description, string genre, string subGenre, string pageLength, int year, double price, double rating, bool hasBeenRead, int timesRead)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            Description = description;
            Genre = genre;
            SubGenre = subGenre;
            PageLength = pageLength;
            Year = year;
            Price = price;
            Rating = rating;
            HasBeenRead = hasBeenRead;
            TimesRead = timesRead;
        }
        public void ReadBook()
        {
            HasBeenRead = true;
            TimesRead++;
        }
    }
}
