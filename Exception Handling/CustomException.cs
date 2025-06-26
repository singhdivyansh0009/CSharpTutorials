using System;

// ✅ Custom Exception Class
class InvalidAgeException : Exception
{
    // ✅ Call base constructor to pass the message to Exception
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age;

        try
        {
            // ✅ Read input and convert to int
            age = Convert.ToInt32(Console.ReadLine());

            // ✅ Throw custom exception if age is invalid
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above.");
            }

            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException ex)
        {
            // ✅ Catch custom exception
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            // ✅ Catch any other exceptions (e.g., format errors)
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
