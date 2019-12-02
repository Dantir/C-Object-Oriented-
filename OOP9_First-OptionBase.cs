using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9
{
    public interface IWriteStrings
    {
        void DisplayPurpose();
        void WritingStrings(string[] strings);
    }
    public class Monitor : IWriteStrings
    {
        public void DisplayPurpose()
        {
            Console.WriteLine("Print lines to the screen");
        }
        public void WritingStrings(string[] strings)
        {
            foreach (var element in strings)
            {
                Console.WriteLine(element);
            }
        }

    }
    public class File : IWriteStrings
    {
        public void DisplayPurpose()
        {
            Console.WriteLine("Print lines to a file");
        }
        public void WritingStrings(string[] strings)
        {
            System.IO.File.WriteAllLines(@"D:\Strings.txt", strings);
        }
    }
    public class SeparateFiles : OptionBase
    {
        public void DisplayPurpose()
        {
            Console.WriteLine("Print lines to seperate files");
        }
        public void WritingStrings(string[] strings)
        {
                for (int i = 0; i < strings.Length; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\" + (i+1) + ".txt"))
                file.WriteLine(strings[i]);
            }
        }
    }
    public class UpperMonitor : IWriteStrings
    {
        public void  DisplayPurpose()
        {
            Console.WriteLine("Print lines to the screen in uppercase");
        }
        public void WritingStrings(string[] strings)
        {
            foreach (var element in strings)
            {
                Console.WriteLine(element.ToUpper());
            }
        }

    }
}
