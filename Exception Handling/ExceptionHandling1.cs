using System;

class Program
{
    public static void Main(String[] args)
    {
        int a = 10;
        int b = 0;
        int c;

        try
        {
            // ❌ This will throw a DivideByZeroException at runtime
            // because division by zero is not allowed in C#.
            c = a / b;
        }
        catch (Exception e)
        {
            // ✅ This block catches any exception of type 'Exception' or its derived types.
            // 'DivideByZeroException' is a subclass of 'Exception', so it will be caught here.
            
            // e.Message contains a human-readable description of the error.
            // For DivideByZeroException, it typically shows: "Attempted to divide by zero."
            Console.WriteLine(e.Message);
        }

        // Program continues after handling the exception (no crash).
    }
}
