using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP12_1_2_
{
    class List: IInputManager
    {
        private List<int> array = new List<int>();
        public void ReadNumber(int number)
        {
            array.Add(number);
        }
        public int SumNumbers()
        {
            return array.Sum();
        }
    }
}
