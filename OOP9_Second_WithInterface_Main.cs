using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person("John", "Doe");
            Person1.ReadBookInformation(0);
            Person1.ReadBookInformation(1);
            Person1.ReadBookPage(1,2);
            Console.ReadKey();
        }
    }
}
