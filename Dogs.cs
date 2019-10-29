using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dogs
    {
        private string name;
        private string race;
        private string color;
        private double weight;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Race { get => race; set => race = value; }
        public string Color { get => color; set => color = value; }
        public double Weight { get => weight; /*set => weight = value;*/ }
        public void setWeight(double newWeight)
        {
            if (newWeight < 0)
                return;
            weight = newWeight;
        }
        public int Age { get => age; /*set => age = value;*/ }
        public void setAge(int newAge)
        {
            if (newAge < 0)
                return;
            age = newAge;
        }

        public string info()
        {
            return "\nName = " + Name + "\nShape = " + Race + "\nState = " + Color + "\nWeight = " + Weight + "\nAge = " + Age + "\nDog Age = " + Age*7 + "\n\n";
        }
    }
}
