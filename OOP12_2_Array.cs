using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP12_1_
{
    class Array: IInputManager
    {
        private string[] Strings = new string[0];
        public void StringFilling()
        {
            Console.WriteLine("Please write numbers to add to your array (write 'done' to stop)\n*Please write only numbers!");
            string input = Console.ReadLine();
            while (input.ToLower() != "break")
            {
                Strings = Strings.Concat(new string[] { input }).ToArray();
                input = Console.ReadLine();
            }
        }
        public void NumberFilling()
        {
            int sum = 0;
            foreach (string element in Strings)
            {
                sum = sum + int.Parse(element);
            }
            Console.WriteLine(sum);
        }
    }
}
