using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3 };
        int a = 10;
        int b = 0;

        try
        {
            // ❌ This will throw DivideByZeroException
            int result = a / b;

            // ❌ This line will not be reached because exception occurs above
            Console.WriteLine(arr[5]); // IndexOutOfRangeException
        }
        catch (DivideByZeroException ex)
        {
            // ✅ Catches divide by zero errors
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            // ✅ Catches invalid array index access
            Console.WriteLine("Error: Array index is out of bounds.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            // ✅ Generic catch block to handle any other exceptions
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine("Details: " + ex.Message);
        }
        finally
        {
            // ✅ This block always executes, even if no exception occurs
            Console.WriteLine("Execution completed.");
        }
    }
}
