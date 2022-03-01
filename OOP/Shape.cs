using System;
namespace OOP
{
    // abstract class
    abstract class Shape
    {
        private int id; // This value cannot be used on the subclasses of this superclass directly because of private accesor

        protected int id2;

        public Shape(int id) // Because this class has a constructor, its subclasses should implement the constructor
        {
            this.id = id;
        }

        // abstract method
        public abstract int area();
    }
}
