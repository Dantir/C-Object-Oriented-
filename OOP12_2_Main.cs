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
            IInputManager Strings = null;
            Console.WriteLine("What do you want to use? \n1 - Array \n2 - List");
            int index = int.Parse(Console.ReadLine());
            if (index == 1)
            { Strings = new Array(); }
            else
            { Strings = new List(); }
            Console.WriteLine("Please write numbers to add to your array or list (write 'done' to stop)\n*Please write only numbers!");
            string input = Console.ReadLine();
            while (input != "done")
            {
                Strings.ReadNumber(int.Parse(input));
                input = Console.ReadLine();
            }
            Console.WriteLine("Sum: " + Strings.SumNumbers());

            Console.ReadKey();
        }
    }
}
