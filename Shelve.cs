using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Shelve
    {
        private Book[] Books;

        public void setbooks()
        {
            Books = new Book[10];
            for (int i = 0; i < 10; i++)
            {
                Books[i] = new Book();
                Books[i].Id = i;
                Books[i].Title = "name " + i;
                Books[i].Author = "auth " +i;
            }
        }
        public void getbooks()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Books[i].Title);
            }
        }
    }
}
