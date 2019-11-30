using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9
{
    public interface OptionBase
    {
        void DisplayPurpose();
        void WritingStrings(string[] Strings);
    }
    public class Monitor : OptionBase
    {
        public void DisplayPurpose()
        {
            Console.WriteLine("Print lines to the screen");
        }
        public void WritingStrings(string[] Strings)
        {
            foreach (var element in Strings)
            {
                Console.WriteLine(element);
            }
        }

    }
    public class File : OptionBase
    {
        public void DisplayPurpose()
        {
            Console.WriteLine("Print lines to a file");
        }
        public void WritingStrings(string[] Strings)
        {
            System.IO.File.WriteAllLines(@"D:\Strings.txt", Strings);
        }
    }
    public class SeparateFiles : OptionBase
    {
        public void DisplayPurpose()
        {
            Console.WriteLine("Print lines to seperate files");
        }
        public void WritingStrings(string[] Strings)
        {
                for (int i = 0; i < Strings.Length; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\" + (i+1) + ".txt"))
                file.WriteLine(Strings[i]);
            }
        }
    }
    public class UpperMonitor : OptionBase
    {
        public void  DisplayPurpose()
        {
            Console.WriteLine("Print lines to the screen in uppercase");
        }
        public void WritingStrings(string[] Strings)
        {
            foreach (var element in Strings)
            {
                Console.WriteLine(element.ToUpper());
            }
        }

    }
}
