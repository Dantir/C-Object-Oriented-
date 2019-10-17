using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum Colors
        {
            Black=1,
            White,
            Red,
            Blue,
            Yellow
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Choose the color for the background");
                foreach (Colors color in Enum.GetValues(typeof(Colors)))
                {
                    Console.Write(color + "\t");
                    Console.WriteLine((int)color);
                }
                try
                {
                    Colors choice = (Colors)Enum.Parse(typeof(Colors),Console.ReadLine());
                    if (choice == Colors.Black)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                    }
                    else if (choice == Colors.White)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Not supported");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please, write a number!");
                }
            }
        }
    }
}
