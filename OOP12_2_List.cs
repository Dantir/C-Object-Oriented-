using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP12_1_
{
    class List: IInputManager
    {
        private List<string> Strings = new List<string>();
        public void StringFilling()
        {
            Console.WriteLine("Please write numbers to add to your list (write 'done' to stop)\n*Please write only numbers!");
            string input = Console.ReadLine();
            while (input.ToLower() != "done")
            {
                Strings.Add(input);
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
