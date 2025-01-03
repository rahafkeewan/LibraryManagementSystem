using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : LibraryItem
    {
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public int Pages { get; private set; }

        public Book(int id, string titleofbook, string author, string genre, int pages) : base(id, titleofbook)
        {
            Author = author;
            Genre = genre;
            Pages = pages;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Book ID: {ID}, Title: {TitleOfBook}, Author: {Author}, Genre: {Genre}, Pages: {Pages}, Borrowed: {IsBorrowed}");
        }
    }
}
