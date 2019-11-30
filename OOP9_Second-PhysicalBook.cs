using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    public class PhysicalBook : Book
    {
        private string dimensions;
        private int weight;
        public PhysicalBook(string name, string author, string[] pages, string dimensions, int weight) : base(name, author, pages)
        {
            this.dimensions = dimensions;
            this.weight = weight;
        }
        public override void PrintInfoBook()
        {
            Console.WriteLine("Name: " + name + "\nAuthor: " + author + "\nNumber of pages: "
                                + pages.Length + "\nDimensions: " + dimensions + "\nWeight: " + weight);

        }
    }
}
