using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write a sentence");
            string Sentence = Console.ReadLine();

            Console.WriteLine(Sentence
                .TrimStart(new[] { '!', '-', '/' })
                .Substring(0, 20)
                .Replace('a', 'A')
                .Replace('e', 'E')
                .Replace('i', 'I')
                .Replace('o', 'O')
                .Replace('u', 'U'));

            Console.ReadKey();
        }
    }
}
