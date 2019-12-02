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
            IWriteStrings[] array = new IWriteStrings[4];
            array[0] = new Monitor();
            array[1] = new File();
            array[2] = new SeparateFiles();
            array[3] = new UpperMonitor();
            Console.WriteLine("Choose the option you want to use: (For your own safety don't write other numbers or especially letters)");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + " - ");
                array[i].DisplayPurpose();
            }
            int index = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[5];
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine("Please write the string number " + (i + 1));
                strings[i] = Console.ReadLine();
            }
            array[index].WritingStrings(strings);
            Console.ReadKey();
        }
    }
}
