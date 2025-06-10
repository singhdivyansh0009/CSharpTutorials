// Properties are the member of the class that can be accessible outside the class using accessors like get and set

using System;
class Properties
{
    // Private field to store the radius
    int _Radius;

    // Public property to access _Radius using getter and setter
    public int Radius
    {
        // set accessor - assigns the value to the private field _Radius
        set
        {
            _Radius = value;
        }

        // get accessor - retrieves the value of _Radius
        get
        {
            return _Radius;
        }
    }
}

class TestProperty
{
    public static void Main(String[] args)
    {
        Properties obj = new Properties(); // create an object of Properties class

        obj.Radius = 10; // Calls set accessor to set _Radius to 10
        Console.WriteLine(obj.Radius); // Calls get accessor to print 10

        obj.Radius = 20; // Calls set accessor to set _Radius to 20
        Console.WriteLine(obj.Radius); // Calls get accessor to print 20
    }
}
