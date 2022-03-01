using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);
            Shape circle = new Circle(5, "1");

            // calling the method
            double result = sh.area();
            double circleArea = circle.area();

            Console.WriteLine("{0}", result);
            Console.WriteLine("{0}", circleArea);
        }
    }
}
