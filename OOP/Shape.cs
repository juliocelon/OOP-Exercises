using System;
namespace OOP
{
    // abstract class
    abstract class Shape
    {
        private int id; // This property cannot be used on the subclasses of this superclass directly because of private accesor

        protected int id2; // This property has access just to subclasses that inherit of this class

        public Shape(int id) // Because this class has a constructor, its subclasses should implement the constructor
        {
            this.id = id;
        }

        // abstract method
        public abstract int area();
    }

    /*
     * An interface only allows you to define functionality, not implement it
       A class can extend of multiple interfaces. 
     */
    public interface IInterface1 // An interface
    {
        public void show();
    }
}
