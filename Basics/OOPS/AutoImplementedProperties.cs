// Properties are members of the class that can be accessed outside the class using accessors like get and set

using System;

class Properties
{
    // Auto-implemented property with both get and set accessors.
    // This allows read and write access from outside the class.
    public int Radius { get; set; }

    // Auto-implemented property with a private set accessor.
    // This means the value can only be modified inside the class (e.g., in constructor).
    public int Data { get; private set; }

    // Constructor that takes an integer and assigns it to the Data property
    public Properties(int data)
    {
        // Initializes the read-only (from outside) Data property
        Data = data;
    }
}

class TestProperty
{
    public static void Main(String[] args)
    {
        // Create an object of Properties class and pass 20 to the constructor
        // This sets Data = 20
        Properties obj = new Properties(20);

        // Set the Radius property using the set accessor
        obj.Radius = 10;

        // Get the value of Radius using the get accessor — prints 10
        Console.WriteLine(obj.Radius);

        // Get the value of Data using the get accessor — prints 20
        // Even though the set accessor is private, the get accessor is public
        Console.WriteLine(obj.Data);
    }
}
