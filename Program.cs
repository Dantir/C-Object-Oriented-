using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Array = new Fruit[5];
            // Array[0] = new Orange(Season.Spring);
            // Array[1] = new Banana("Canada");
            // Array[2] = new Coconut("Kuala Lumpur");
            Array[0] = new Banana("Poland", 8.2);
            Array[1] = new Coconut("Poland", 19.9);
            Array[2] = new Orange("Poland", Season.Spring, 10);
            Array[3] = new Orange("Poland", Season.Summer, 10);
            Array[4] = new Orange("Poland", Season.Winter, 10);

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i].GetPricePerKg());
            }
            Console.ReadKey();
        }
    }
}
