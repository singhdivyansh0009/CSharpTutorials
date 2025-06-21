using System;

// Rule 1: An interface defines a contract (only method signatures, no implementation)
interface Test {
    int Add(int a, int b); // Rule 2: Interface members are public and abstract by default
}

interface Test1 {
    int Sub(int a, int b);
}

// Rule 3: A class can implement multiple interfaces (unlike classes, which only support single inheritance)
class A : Test, Test1 {
    // Rule 4: All interface methods must be implemented in the implementing class
    public int Add(int a, int b) {
        return a + b;
    }

    public int Sub(int a, int b) {
        return a - b;
    }
}

class program {
    public static void Main(string[] args) {
        // Example 1: Using class reference (can access all public methods of the class)
        A obj = new A();
        Console.WriteLine(obj.Add(10, 20)); // Output: 30

        // Example 2: Using interface reference (can access only methods defined in that interface)
        Test t = new A(); // Rule 5: You can reference an object of the implementing class using interface type
        Console.WriteLine(t.Add(10, 20)); // Allowed
        // Console.WriteLine(t.Sub(10, 5)); // ❌ Not allowed - 't' is of type Test which doesn't have Sub()

        Test1 t1 = new A();
        Console.WriteLine(t1.Sub(20, 5)); // Allowed

        // Rule 6: You cannot create an instance of an interface directly
        // Test myTest = new Test(); // ❌ Not allowed
    }
}
