using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Book
    {
        private int id;
        private string title;
        private string author;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }

    }
}
