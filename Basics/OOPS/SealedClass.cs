using System;

// A sealed class cannot be inherited by any other class.
// It is used when we want to restrict other classes from deriving from it.
public sealed class TestClass
{
    // Regular method in the sealed class
    public void Display()
    {
        Console.WriteLine("This is sealed class");
    }
}

// ❌ This will cause a compilation error:
// error CS0509: 'ChildTestClass': cannot derive from sealed type 'TestClass'

// public class ChildTestClass : TestClass
// {
//     // Compilation error: Cannot inherit from a sealed class
// }

public class Program
{
    public static void Main(string[] args)
    {
        // Creating object of sealed class and calling its method
        TestClass t = new TestClass();
        t.Display(); // Output: This is sealed class
    }
}
