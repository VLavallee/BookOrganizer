namespace BookOrganizer.Tests
{
    public class BookManagerTests
    {
        [Fact]
        public void GetCount_Get_Books_Count()
        {
            // Arrange
            BookManager bookManager = new BookManager();
            int defaultCount = 5;
            int count = 0;
            // Act
            count = bookManager.GetCount();
            // Assert
            Assert.Equal(defaultCount, count);
        }
        [Fact]
        public void AddBook_Adds_A_Book_To_Books()
        {
            // Arrange
            BookManager bookManager = new BookManager();
            int totalAfterAddingABook = 6;
            string title = "bookTitle";
            string first = "firstName";
            string last = "lastName";
            // Act
            bookManager.AddBook(title, first, last);
            // Assert
            Assert.Equal(bookManager.GetCount(), totalAfterAddingABook);
        }
        [Fact]
        public void SearchByTitle_Searches_A_Book_By_Title()
        {
            // Arrange
            BookManager bookManager = new BookManager();
            string titleToSearch = "Clan of the Cavebear";
            // Act
            bookManager.SearchByTitle(titleToSearch);
            // Assert
            Assert.True(bookManager.SearchByTitle(titleToSearch));
        }

        [Fact]
        public void RemoveBook_Remove_A_Specific_Book()
        {
            // Arrange
            BookManager bookManager = new BookManager();
            string titleToRemove = "Alice's Adventures in Wonderland";
            int totalAfterRemovingOneBook = 4;
            // Act
            bookManager.RemoveBook(titleToRemove);
            // Assert
            Assert.Equal(bookManager.GetCount(), totalAfterRemovingOneBook);
        }

        [Fact]
        public void RemoveAllBooks_Remove_All_Books()
        {
            // Arrange
            BookManager bookManager = new BookManager();
            int totalAfterRemovingAllBooks = 0;
            // Act
            bookManager.RemoveAllBooks();
            // Assert
            Assert.Equal(bookManager.GetCount(), totalAfterRemovingAllBooks);
        }
    }
}