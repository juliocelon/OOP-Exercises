using System;
namespace OOP
{
    class Circle : Shape
    {
        private int radius;

        public Circle(int radius, string id)
            : base(1)
        {
            this.radius = radius;
        }

        public override int area()
        {
            return (int)((int)radius * radius * System.Math.PI);
        }
    }
}
