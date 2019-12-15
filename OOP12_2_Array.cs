using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP12_1_2_
{
    class Array: IInputManager
    {
        private int[] array = new int[10];
        private int arrayindex = 0;
        public void ReadNumber(int number)
        {
            array[arrayindex] = number;
            arrayindex++;
        }
        public int SumNumbers()
        {
            int sum = 0;
            for (int i = 0; i<arrayindex; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
    }
}
