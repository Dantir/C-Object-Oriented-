using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Please, write a sentence");
            string Sentence = Console.ReadLine();
            string[] list = Sentence.Split(' ');

            while (i < list.Length)
            {
                 if (i%2==0)
                 {
                    Console.WriteLine(list[i].ToUpper());
                }
                 else
                 {
                    Console.WriteLine(list[i].ToLower());
                 }
                i++;
            }
            Console.ReadKey();
        }
    }
}
