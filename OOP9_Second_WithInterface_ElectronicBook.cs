using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    public class ElectronicBook : IBook
    {
        private string name;
        private string author;
        private string[] pages;
        private int size;
        public ElectronicBook(string name, string author, string[] pages, int size)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;
            this.size = size;
        }
        public void PrintInfoBook()
        {
            Console.WriteLine("Name: " + name + "\nAuthor: " + author + "\nNumber of pages: "
                                + pages.Length + "\nSize: " + size + " KB");
        }
        public void PrintInfoPage(int pageNumber)
        {
            Console.WriteLine("Name: " + name + "\nContents of page " + pageNumber + " is: " + pages[pageNumber]);
        }
    }
}
