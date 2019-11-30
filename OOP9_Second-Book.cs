using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    public abstract class Book
    {
        protected string name;
        protected string author;
        protected string[] pages;
        public Book(string name, string author, string[] pages)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;
        }
        public abstract void PrintInfoBook();
        public void PrintInfoPage(int pageNumber)
        {

            Console.WriteLine("Name: " + name + "\nContents of page " + pageNumber + " is: " + pages[pageNumber]);
        }
    }
}
