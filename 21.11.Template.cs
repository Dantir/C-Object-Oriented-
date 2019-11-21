        public abstract class Fruit
    {
        public string OriginCountry{ get; protected set; }
        public abstract bool ContainsJuice();
        public double PricePerKg { get; protected set; }
        public Fruit (double pricePerKg)
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
        public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
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
        
        
        
        static void Main(string[] args)
        {
            Fruit[] Array = new Fruit[5];
            // Array[0] = new Orange(Season.Spring);
            // Array[1] = new Banana("Canada");
            // Array[2] = new Coconut("Kuala Lumpur");
            Array[0] = new Banana("Poland", 8.2);
            Array[1] = new Coconut("Poland", 19.9);
            Array[2] = new Orange("Poland", Season.Spring, 10);
            Array[3] = new Orange("Poland",  Season.Summer, 10);
            Array[4] = new Orange("Poland",  Season.Winter, 10);

            for (int i = 0; i<Array.Length;i++)
            {
                Console.WriteLine(Array[i].GetPricePerKg());
            }
            Console.ReadKey();
        }
