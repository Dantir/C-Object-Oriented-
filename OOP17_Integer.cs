using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class UnsignedInt
    {
        int Integer;
        public UnsignedInt(int Integer)
        {
            if (Integer < 0)
                this.Integer = 0;
            else
                this.Integer = Integer;
        }
        public static UnsignedInt operator +(UnsignedInt a, UnsignedInt b)
        {
            return new UnsignedInt(a.Integer + b.Integer);
        }
        public static UnsignedInt operator +(UnsignedInt a, int b)
        {
            return new UnsignedInt(a.Integer + b);
        }
        public static UnsignedInt operator +(int b, UnsignedInt a)
        {
            return a + b;
        }
        public static UnsignedInt operator -(UnsignedInt a, UnsignedInt b)
        {
            return new UnsignedInt(a.Integer - b.Integer);
        }
        public static UnsignedInt operator -(UnsignedInt a, int b)
        {
            return new UnsignedInt(a.Integer - b);
        }
        public static UnsignedInt operator -(int b, UnsignedInt a)
        {
            return new UnsignedInt(b - a.Integer);
        }
        public static UnsignedInt operator *(UnsignedInt a, UnsignedInt b)
        {
            return new UnsignedInt(a.Integer * b.Integer);
        }
        public static UnsignedInt operator *(UnsignedInt a, int b)
        {
            return new UnsignedInt(a.Integer * b);
        }
        public static UnsignedInt operator *(int b, UnsignedInt a)
        {
            return a * b;
        }
        public static UnsignedInt operator /(UnsignedInt a, UnsignedInt b)
        {
            if (b.Integer == 0)
            {
                return new UnsignedInt(0);
            }
            else
            return new UnsignedInt(a.Integer / b.Integer);
        }
        public static UnsignedInt operator /(UnsignedInt a, int b)
        {
            if (b == 0)
            {
                return new UnsignedInt(0);
            }
            return new UnsignedInt(a.Integer / b);
        }
        public static UnsignedInt operator /(int b, UnsignedInt a)
        {
            if (a.Integer == 0)
            {
                return new UnsignedInt(0);
            }
            return new UnsignedInt(b / a.Integer);
        }
        public override string ToString()
        {
            return Integer.ToString();
        }
    }
}
