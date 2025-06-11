using System;

class Constructor
{
    // Private backing fields (not used here)
    int _i;
    float _j;
    string _k;

    // Auto-implemented read-only properties
    public int i { get; }      // default value: 0
    public bool j { get; }     // default value: false
    public string k { get; }   // default value: null

    // ✅ Implicit constructor:
    // Since no constructor is defined, the compiler provides a default **parameterless constructor**
    // This is called the **implicit default constructor**.
    // It initializes all fields/properties with their default values:
    // int → 0, bool → false, string → null
}

class TestConstructor
{
    public static void Main(string[] args)
    {
        // Calling the implicit default constructor
        Constructor obj = new Constructor(); 

        // Output default values of auto-properties:
        Console.WriteLine(obj.i);  // Output: 0 (default of int)
        Console.WriteLine(obj.j);  // Output: False (default of bool)
        Console.WriteLine(obj.k);  // Output: (blank line, because it's null)
    }
}
