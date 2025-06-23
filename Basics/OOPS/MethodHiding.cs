using System;

class Parent
{
    // This is the method in the Parent class
    public void Print()
    {
        Console.WriteLine("Parent Method");
    }
}

class Child : Parent
{
    // This method hides the Parent class method (not overriding)
    // 'new' keyword tells the compiler to hide the inherited method
    public new void Print()
    {
        Console.WriteLine("Child Method");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Object of Child class, reference is also Child
        // So Child's Print() method will be called
        Child obj1 = new Child();
        obj1.Print(); // Output: "Child Method"

        // Object is of Child class, but reference is of Parent type
        // Due to method hiding, method is resolved at compile-time using reference type
        /
