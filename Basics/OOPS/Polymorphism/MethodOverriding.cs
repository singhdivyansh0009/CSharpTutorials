using System;

class Parent
{
    // This method is marked as virtual, which means it can be overridden in a derived class
    public virtual void Print()
    {
        Console.WriteLine("Parent Method");
    }
}

class Child : Parent
{
    // This overrides the Parent's Print method
    public override void Print()
    {
        Console.WriteLine("Child Method");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Reference and object both are of Child type
        // So Child's overridden method will be called
        Child obj1 = new Child();
        obj1.Print(); // Output: "Child Method"

        // Object is of Child type, but reference is of Parent type
        // Since the method is overridden, runtime checks the actual object type
        // So Child's Print() will be called (polymorphism)
        Parent obj2 = new Child();
        obj2.Print(); // Output: "Child Method"
    }
}
