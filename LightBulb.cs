using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LightBulb
    {
        private string color;
        private string shape;
        private string state;

        public string Color { get => color; set => color = value; }
        public string Shape { get => shape; set => shape = value; }
        public string GetState()
        {
            return state;
        }
        public void SetState(string newState)
        {
            state = newState;
            Console.WriteLine("\nNew state: " + state);
        }
        public string info()
        {
            return "\nColor = " + Color + "\nShape = " + Shape + "\nState = " + GetState() + "\n";
        }
    }
}
