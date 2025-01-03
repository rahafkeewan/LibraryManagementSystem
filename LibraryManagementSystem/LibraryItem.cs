using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class LibraryItem
    {
        public int ID { get; private set; }
        public string TitleOfBook { get; private set; }
        public bool IsBorrowed { get; private set; }
        public LibraryItem(int id, string titleofbook)
        {
            ID = id;
            TitleOfBook = titleofbook;
            IsBorrowed = false;
        }

        public void BorrowItem()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"{TitleOfBook} is already borrowed.");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine($"{TitleOfBook} has been borrowed successfully.");
            }
        }

        public abstract void DisplayDetails();
    }
}
