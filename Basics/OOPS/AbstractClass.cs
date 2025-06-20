using System;

// Abstract class declaration
abstract class Payment
{
    // Rule 1: An abstract class can have abstract methods (like below)
    // Rule 2: Abstract methods have no body and must be overridden in derived classes
    public abstract void GetCashback();

    // Rule 3 (optional): Abstract class can also have non-abstract (concrete) methods
    // public void CommonMethod() { Console.WriteLine("Common logic"); }
}

// Rule 4: A class inheriting an abstract class must implement all its abstract methods
class Paytm : Payment
{
    // Rule 5: 'override' keyword is mandatory when implementing an abstract method
    public override void GetCashback()
    {
        Console.WriteLine("You got 10 rupee cashback from paytm");
    }
}

public class program
{
    public static void Main(string[] args)
    {
        // Rule 6: You cannot create an object of an abstract class directly
        // Payment p = new Payment(); // ❌ Not allowed

        // But you can create an object of a derived class
        Paytm p = new Paytm(); // ✅ Allowed
        p.GetCashback(); // Calls the overridden method
    }
}
