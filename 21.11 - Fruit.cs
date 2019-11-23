using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public abstract class Fruit
    {
        public string OriginCountry { get; protected set; }
        public abstract bool ContainsJuice();
        public double PricePerKg { get; protected set; }
        public Fruit(double pricePerKg)
        {
            PricePerKg = pricePerKg;
        }
        public virtual double GetPricePerKg()
        {
            return PricePerKg;
        }
    }
    public class Coconut : Fruit
    {
        public override bool ContainsJuice()
        {
            return true;
        }
        public Coconut(string originCountry, double pricePerKg) : base(pricePerKg)
        {
            OriginCountry = originCountry;
        }
    }
    public class Banana : Fruit
    {
        public override bool ContainsJuice()
        {
            return false;
        }
        public override double GetPricePerKg()
        {
            return PricePerKg * 5;
        }
        public Banana(string originCountry, double pricePerKg) : base(pricePerKg)
        {
            OriginCountry = originCountry;
        }
    }
    public class Orange : Fruit
    {
        public Season Season { get; private set; }
        public override bool ContainsJuice()
        {
            return true;
        }
        public override double GetPricePerKg()
        {
            if (Season == Season.Autumn || Season == Season.Spring)
            { return PricePerKg * 1.5; }
            else if (Season == Season.Summer)
            { return PricePerKg * 2; }
            else
                return PricePerKg;
        }
        public Orange(string originCountry, Season season, double pricePerKg) : base(pricePerKg)
        {
            OriginCountry = originCountry;
            Season = season;
        }
    }
}
