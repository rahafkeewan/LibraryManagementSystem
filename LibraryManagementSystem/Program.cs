using LibraryManagementSystem;

public class Program
{
    static List<LibraryItem> libraryItems = new List<LibraryItem>();
    static int nextId = 1;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nWelcome to the Library Management System!");
            Console.WriteLine("1. Add Library Item");
            Console.WriteLine("2. View All Items");
            Console.WriteLine("3. Borrow an Item");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddLibraryItem();
                        break;
                    case 2:
                        ViewLibraryItems();
                        break;
                    case 3:
                        BorrowLibraryItem();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void AddLibraryItem()
    {
        Console.WriteLine("\nAdd New Library Item:");
        Console.WriteLine("1. Book");
        Console.WriteLine("2. Magazine");
        Console.WriteLine("3. DVD");
        Console.Write("Enter the type of item: ");
        int type;
        if (int.TryParse(Console.ReadLine(), out type))
        {
            switch (type)
            {
                case 1:
                    Console.Write("Enter Book Title: ");
                    string bookTitle = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("Enter Number of Pages: ");
                    int pages;
                    if (int.TryParse(Console.ReadLine(), out pages))
                    {
                        libraryItems.Add(new Book(nextId++, bookTitle, author, genre, pages));
                        Console.WriteLine("Book added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Number of Pages.");
                    }
                    break;
                case 2:
                    Console.Write("Enter Magazine Title: ");
                    string magazineTitle = Console.ReadLine();
                    Console.Write("Enter Publisher: ");
                    string publisher = Console.ReadLine();
                    Console.Write("Enter Issue Number: ");
                    int issueNumber;
                    Console.Write("Enter Year: ");
                    int year;
                    if (int.TryParse(Console.ReadLine(), out issueNumber) && int.TryParse(Console.ReadLine(), out year))
                    {
                        libraryItems.Add(new Magazine(nextId++, magazineTitle, publisher, issueNumber, year));
                        Console.WriteLine("Magazine added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Issue Number or Year.");
                    }
                    break;
                case 3:
                    Console.Write("Enter DVD Title: ");
                    string dvdTitle = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director = Console.ReadLine();
                    Console.Write("Enter Duration (in minutes): ");
                    int duration;
                    if (int.TryParse(Console.ReadLine(), out duration))
                    {
                        libraryItems.Add(new DVD(nextId++, dvdTitle, director, duration));
                        Console.WriteLine("DVD added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Duration.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid type. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static void ViewLibraryItems()
    {
        Console.WriteLine("\n--- Library Items ---");
        if (libraryItems.Count == 0)
        {
            Console.WriteLine("No items available.");
        }
        else
        {
            foreach (var item in libraryItems)
            {
                item.DisplayDetails();
            }
        }
    }

    static void BorrowLibraryItem()
    {
        Console.Write("Enter the ID of the item to borrow: ");
        int id;
        if (int.TryParse(Console.ReadLine(), out id))
        {
            var item = libraryItems.Find(i => i.ID == id);
            if (item != null)
            {
                item.BorrowItem();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid ID.");
        }
    }
}