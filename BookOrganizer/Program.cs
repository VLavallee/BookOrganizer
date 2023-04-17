using System;

namespace BookOrganizer
{
    class Program
    {
        static BookManager books = new BookManager();
        static bool validInput = false;
        static string input;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the book organizer.\n");
            RunOrganizerMain();
        }

        static void RunOrganizerMain()
        {
            do
            {
                DisplayMenu();
                GetUserInput();
                ProcessInput();
            } while (!validInput);
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine($"There are currently {books.GetCount()} books in your collection.");
            Console.WriteLine($"You have {books.GetToBeReadCount()} book(s) in your \"to be read\" list.");
            Console.WriteLine("You have spent $0 dollar(s) on books.\n");
            Console.WriteLine("1. View collection");
            Console.WriteLine("2. Search");
            Console.WriteLine("3. Add book(s)");
            Console.WriteLine("4. Remove book(s)");
            Console.WriteLine("5. Append book(s)");
            Console.WriteLine("0. Quit application\n");
            Console.WriteLine("Please make a selection.\n");
        }

        static void GetUserInput()
        {
            input = Console.ReadLine();
        }

        static void ProcessInput()
        {
            if (int.TryParse(input, out int selection))
            {
                switch (selection)
                {
                    case 1:
                        books.ViewCollection();
                        ShowCollectionOptions();
                        break;
                    case 2:
                        // TO DO: Search
                        break;
                    case 3:
                        AddBookOption();
                        break;
                    case 4:
                        // TO DO: Remove book(s)
                        break;
                    case 5:
                        // TO DO: Append book(s)
                        break;
                    case 0:
                        validInput = true;
                        break;
                    default:
                        DisplayInvalidSelectionMessage();
                        break;
                }
            }
            else
            {
                DisplayInvalidInputMessage();
            }
        }

        static void DisplayInvalidSelectionMessage()
        {
            Console.WriteLine("Invalid selection. Select an available option and try again.\n");
            Console.ReadKey();
        }

        static void DisplayInvalidInputMessage()
        {
            Console.WriteLine("Invalid input. Select an available option and try again.\n");
            Console.ReadKey();
        }

        static void AddBookOption()
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
            RunOrganizerMain();
        }

        static void ShowCollectionOptions()
        {
            Console.WriteLine("\n");
            Console.WriteLine("8. To main page");
            Console.WriteLine("9. Append book detail");
            Console.WriteLine("0. Quit");
            Console.WriteLine("\n");
            Console.WriteLine("Select the corresponding book # for more options.");
            Console.WriteLine("\n");

            do
            {
                string bookDetailUserInput = Console.ReadLine();

                if (int.TryParse(bookDetailUserInput, out int selection))
                {
                    if (selection >= 1 && selection < books.GetCount() + 1)
                    {
                        Console.Clear();
                        Console.WriteLine("\n");
                        books.ViewBookDetails(selection);
                        Console.WriteLine("\n");

                    }
                }
                else
                {
                    DisplayInvalidInputMessage();
                }
            } while (!validInput);
        }
        static void ShowBookDetailOptions()
        {

        }
    }
}