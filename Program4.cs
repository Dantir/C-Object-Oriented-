using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int infinity = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Write the first integer");
                    int first = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the second integer");
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine(first / second);
                }
                catch(DivideByZeroException a)
                {
                    Console.WriteLine("Not possible to divide by 0!");
                }
                catch (FormatException b)
                {
                    Console.WriteLine("Numbers have to be integers!");
                }
                finally
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
