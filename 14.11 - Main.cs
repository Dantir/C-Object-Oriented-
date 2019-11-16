namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] Array = new Shape[3];
            Array[0] = new Square(4);
            Array[1] = new Rectangle(4,2);
            Array[2] = new Circle(5);
            Console.WriteLine(Array[0].GetArea());
            Console.WriteLine(Array[0].ToString());
            Console.WriteLine(Array[1].GetArea());
            Console.WriteLine(Array[1].ToString());
            Console.WriteLine(Array[2].GetArea());
            Console.WriteLine(Array[2].ToString());
            Console.ReadKey();
        }
    }
}
