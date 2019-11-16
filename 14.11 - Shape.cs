namespace ConsoleApp1
{
    public class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
        public virtual string ToString()
        {
            return "Area ->" + 0;
        }
    }
    public class Square : Shape
    {
        public int Sidelength { get; private set; }
        public Square(int height)
        {
            Sidelength = height;
        }
        public int size { get; private set; }
        public override double GetArea()
        {
            return size = Sidelength * Sidelength;
        }
        public override string ToString()
        {
            return "Square - Area -> " + size + " m2";
        }
    }
    public class Rectangle : Square
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public Rectangle(int height, int width):base(height)
        {
            Height = height;
            Width = width;
        }
        public int size { get; private set; }
        public override double GetArea()
        {
            return size =  Height * Width;
        }
        public override string ToString()
        {
            return "Rectangle - Area -> " + size + " m2";
        }
    }
    public class Circle  : Shape 
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double size { get; private set; }
        public override double GetArea()
        {
            return size = Radius * Radius * 3.14;
        }
        public override string ToString()
        {
            return "Circle - Area -> " + size + " m2";
        }
    }
}
