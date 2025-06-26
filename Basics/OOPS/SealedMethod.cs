using System;

// 🔹 Base class
public class TestClass
{
    // ✅ This method is declared as virtual,
    // meaning it *can* be overridden in a derived class.
    public virtual void Display()
    {
        Console.WriteLine("This is sealed method of parent");
    }

    // ❌ If we directly wrote:
    // public sealed void Display() { ... }
    // It would cause a compile-time error:
    // CS0238: "cannot be sealed because it is not an override"
    // Because only an overridden method can be sealed.
}

// 🔹 First derived class
public class ChildTestClass : TestClass
{
    // ✅ This is an *overridden* method from the base class.
    // We are also marking it as *sealed*, meaning this override
    // cannot be overridden further in any subclass.
    public sealed override void Display()
    {
        Console.WriteLine("This is sealed method of parent");
    }

    // ❌ If we omit 'override' and try to define 'Display()' again with sealed,
    // like: public sealed void Display() { ... }
    // It will still be invalid because 'sealed' requires 'override'.
}

// 🔹 Second derived class (grandchild)
public class GrandChilTestClass : ChildTestClass
{
    // ❌ This will cause a compile-time error:
    // CS0239: "Display(): cannot override inherited member because it is sealed"
    // Because the method was sealed in ChildTestClass.

    // public override void Display()
    // {
    //     Console.WriteLine("Trying to override sealed method");
    // }
}

public class Program
{
    public static void Main(string[] args)
    {
        // ✅ You can still create an object of the base class and call the method.
        TestClass t = new TestClass();
        t.Display();

        // ✅ You can also call the sealed override via the child class.
        ChildTestClass ct = new ChildTestClass();
        ct.Display();

        // ✅ Grandchild can still use inherited sealed method,
        // but it cannot override it.
        GrandChilTestClass gct = new GrandChilTestClass();
        gct.Display();
    }
}
