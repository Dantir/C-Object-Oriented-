using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP12_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputManager Strings;
            Console.WriteLine("What do you want to use? \n1 - Array \n2 - List");
            int index = int.Parse(Console.ReadLine());
            if (index ==1)
            {Strings = new Array();}
            else
            {Strings = new List();}

            Strings.StringFilling();
            Strings.NumberFilling();

            Console.ReadKey();
        }
    }
}
