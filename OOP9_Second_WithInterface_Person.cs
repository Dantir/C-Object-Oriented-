using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    class Person
    {
        private IBook[] Books = new IBook[2];
        private string name;
        private string surname;
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            Books[0] = new PhysicalBook("Some title", "Some author", 
                new string[]{  "It will work?" ,  "I think it actually works" ,  "No way"}, "19x16 cm", 2);
            Books[1] = new ElectronicBook("Some other title", "Some other author", 
                new string[] { "This is a page","This is not a page", "funny", "or not really" } , 2000);
        }
        public void ReadBookInformation(int bookPosition)
        {
            Books[bookPosition].PrintInfoBook();
        }
        public void ReadBookPage(int bookPosition, int pageNumber)
        {
            Books[bookPosition].PrintInfoPage(pageNumber);
        }
    }
}
