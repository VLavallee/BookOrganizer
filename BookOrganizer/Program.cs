
using BookOrganizer;


Console.WriteLine("Welcome to the book organizer.\n");

BookManager books = new BookManager();
bool validInput = false;
string input;


ShowStartupOptions();


void ShowStartupOptions()
{
    do
    {
        Console.Clear();
        Console.WriteLine("There are currently " + books.GetCount() + " books in your collection.");
        Console.WriteLine("You have 0 book(s) in your \"to be read\" list.");
        Console.WriteLine("You have spent $0 dollar(s) on books.\n");
        Console.WriteLine("1. View collection");
        Console.WriteLine("2. Search");
        Console.WriteLine("3. Add book(s)");
        Console.WriteLine("4. Remove book(s)");
        Console.WriteLine("5. Append book(s)");
        Console.WriteLine("9. Quit application\n");
        Console.WriteLine("Please make a selection.\n");
        input = Console.ReadLine();
        int selection;

        // takes the user input and tries to parse it as an int
        if (int.TryParse(input, out selection))
        {
            //if parsed as int successful it looks for case matching the int
            switch (selection)
            {
                case 1:
                    books.ViewCollection();
                    GetCollectionUserInput();
                    break;
                case 2:
                    // TO DO
                    // Search
                    break;
                case 3:
                    // Add book(s)
                    AddBookOption();
                    validInput = true;
                    Console.WriteLine();
                    ShowStartupOptions();
                    validInput = false;
                    break;
                case 4:
                    // Remove book(s)
                    // TO DO
                    break;
                case 5:
                    // Append book(s)
                    // TO DO
                    break;
                case 9:
                    // Quit application
                    // TO DO
                    validInput = true;
                    break;
                    // if the int did not match any case it gives this message
                default:
                    Console.WriteLine("Invalid selection. Select an available option and try again.\n");
                    Console.ReadKey();
                    break;
            }
        }
        // if parse failed it gives this message
        else
        {
            Console.WriteLine("Invalid input. Select an available option and try again.\n");
            Console.ReadKey();
        }
        // stay in this loop until validInput = true
    } while (!validInput);
}


void AddBookOption()
{
    Console.Clear();
    Console.WriteLine("Enter the title.");
    string title = Console.ReadLine();
    Console.WriteLine("Enter the author's first name.");
    string first = Console.ReadLine();
    Console.WriteLine("Enter the author's last name.");
    string last = Console.ReadLine();
    books.AddBook(title, first, last);
    validInput = false;
    ShowStartupOptions();
}
void GetCollectionUserInput()
{
    // TO DO
    // Currently only allows to look at a book. 
    do
    {
        string collectionUserInput = Console.ReadLine();
        int selection;

        // takes the user input and tries to parse it as an int for books index
        if (int.TryParse(collectionUserInput, out selection))
        {
            if(selection >= 1 && selection < books.GetCount() + 1)
            {
                Console.WriteLine("\n");
                books.ViewBookDetails(selection);
            }
        }
        // if parse failed it gives this message
        else
        {
            Console.WriteLine("Invalid input. Select an available option and try again.\n");
            Console.ReadKey();
        }

        // stay in this loop until validInput = true
    } while (!validInput);
}



