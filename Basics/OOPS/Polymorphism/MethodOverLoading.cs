using System;

class Calculator
{
    // Method 1: Sum of two integers
    public int Sum(int a, int b)
    {
        return a + b;
    }

    // Method 2: Sum of two doubles
    // This is a different method because the parameter types are different
    public double Sum(double a, double b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an object of Calculator class
        Calculator c = new Calculator();

        // Calls the int version of Sum (because arguments are integers)
        Console.WriteLine(c.Sum(10, 20)); // Output: 30

        // Calls the double version of Sum (because arguments are doubles)
        Console.WriteLine(c.Sum(10.028, 20.288)); // Output: 30.316
    }
}
