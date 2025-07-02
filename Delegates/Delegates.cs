using System;

namespace Delegates
{
    // Step 1: Declare a delegate
    // A delegate is a reference type that holds a reference to a method with a specific signature.
    // In this case, it can reference any method that returns void and takes two double parameters.
    public delegate void RectDelegate(double a, double b);

    class Rectangle
    {
        // Instance method to calculate area
        public void getArea(double l, double b)
        {
            Console.WriteLine("Area of Rect: " + (l * b));
        }

        // Static method to calculate perimeter
        public static void getPerimeter(double l, double b)
        {
            Console.WriteLine("Perimeter of Rect: " + 2 * (l + b));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(); // Creating an object of Rectangle class

            // Normal way of calling methods
            // r1.getArea(10.0, 10.2);
            // Rectangle.getPerimeter(10.0, 10.2);

            // Step 2: Create delegate object and associate it with method
            // The method signature must match the delegate signature exactly
            // You can assign the method reference directly to the delegate
            RectDelegate rd = new RectDelegate(r1.getArea);
            // or simply:
            // RectDelegate rd = r1.getArea;

            // Step 3: Invoke the method through the delegate
            rd(10.0, 10.0);          // using shorthand
            // or
            rd.Invoke(10.0, 10.0);   // using Invoke method (explicit call)
        }
    }
}
