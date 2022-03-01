using System;
namespace OOP
{
    // square class inheriting
    class Square : Shape, IInterface1
    {
        private int side;

        public Square(int x = 0)
            :base(5)
        {
            side = x;
            id2 = 5;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }

        public void show()
        {
            Console.WriteLine("Show from interface");
        }
    }
}
