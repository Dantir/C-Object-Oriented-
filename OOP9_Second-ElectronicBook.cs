using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    public class ElectronicBook : Book
    {
        private int size;
        public ElectronicBook(string name, string author, string[] pages, int size) : base(name, author, pages)
        {
            this.size = size;
        }
        public override void PrintInfoBook()
        {
            Console.WriteLine("Name: " + name + "\nAuthor: " + author + "\nNumber of pages: "
                                + pages.Length + "\nSize: " + size + " KB");
        }
    }
}
