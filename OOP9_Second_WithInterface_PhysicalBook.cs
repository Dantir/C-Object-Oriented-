using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    public class PhysicalBook : IBook
    {
        private string name;
        private string author;
        private string[] pages;
        private string dimensions;
        private int weight;
        public PhysicalBook(string name, string author, string[] pages, string dimensions, int weight)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;
            this.dimensions = dimensions;
            this.weight = weight;
        }
        public void PrintInfoBook()
        {
            Console.WriteLine("Name: " + name + "\nAuthor: " + author + "\nNumber of pages: "
                                + pages.Length + "\nDimensions: " + dimensions + "\nWeight: " + weight);
        }
        public void PrintInfoPage(int pageNumber)
        {
            Console.WriteLine("Name: " + name + "\nContents of page " + pageNumber + " is: " + pages[pageNumber]);
        }
    }
}
