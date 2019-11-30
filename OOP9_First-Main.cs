using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionBase[] Array = new OptionBase[4];
            Array[0] = new Monitor();
            Array[1] = new File();
            Array[2] = new SeparateFiles();
            Array[3] = new UpperMonitor();
            Console.WriteLine("Choose the option you want to use: (For your own safety don't write other numbers or especially letters)");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(i + " - ");
                Array[i].DisplayPurpose();
            }
            int index = Convert.ToInt32(Console.ReadLine());
            string[] Strings = new string[5];
            for (int i = 0; i < Strings.Length; i++)
            {
                Console.WriteLine("Please write the string number " + (i + 1));
                Strings[i] = Console.ReadLine();
            }
            Array[index].WritingStrings(Strings);
            Console.ReadKey();
        }
    }
}
