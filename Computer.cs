using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Color { Black = 1, Gray = 2, White = 3 }
    public class Computer
    {
        /*public Computer(double MonitorWidth, double MonitorHeight)
           {
               Colorname = Color.Black;
               Brand = "Undefined";
               this.MonitorWidth = MonitorWidth;
               this.MonitorHeight = MonitorHeight;
           }*/
        /*public Computer(Color Colorname, string Brand, double MonitorWidth, double MonitorHeight)
        {
            this.Colorname = Colorname;
            this.Brand = Brand;
            this.MonitorWidth = MonitorWidth;
            this.MonitorHeight = MonitorHeight;
        }*/
        private Color colorname;
        public Color Colorname
        {
            get { return colorname; }
            set { colorname = value; }
        }
        private string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                { brand = value; }
                else
                { Console.WriteLine("Invalid data (String can't be empty!)"); }
            }
        }
        private double monitorWidth;
        public double MonitorWidth
        {
            get { return monitorWidth; }
            set
            {
                if (value >= 0)
                { monitorWidth = value; }
                else
                { Console.WriteLine("Invalid data (Number should be positive!)"); }
            }
        }
        private double monitorHeight;
        public double MonitorHeight
        {
            get { return monitorHeight; }
            set
            {
                if (value >= 0)
                { monitorHeight = value; }
                else
                { Console.WriteLine("Invalid data (Number should be positive!)"); }
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("\nThe brand is " + Brand + "\nThe color is " + Colorname + "\nThe resolution is " + MonitorWidth + " x " + MonitorHeight);
        }
        public double Area()
        {
            return (MonitorWidth * MonitorHeight);
        }
        public Computer Clone()
        {
            Computer Clone = new Computer();
            Clone.Colorname = Colorname;
            Clone.Brand = Brand;
            Clone.MonitorWidth = MonitorWidth;
            Clone.MonitorHeight = MonitorHeight;
            return Clone;
        }
    }
}
