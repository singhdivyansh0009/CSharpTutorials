using System;

namespace Delegates
{
    // You can define custom delegates like below (commented out since we're using generic ones)
    // public delegate int SumDelegate(int a, int b);
    // public delegate void GreetingDelegate(string s);
    // public delegate bool CheckDelegate(int n);

    class GenricDelegate
    {
        // Method that adds two integers and returns the result
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // Method that takes a string and prints a greeting message
        public void Greeting(string name)
        {
            Console.WriteLine("Happy Birthday " + name);
        }

        // Method that checks if a number is even
        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            GenricDelegate g = new GenricDelegate(); // Create an object of GenricDelegate

            // Instead of using custom delegate types, we use built-in generic delegates here:

            // Func<T1, T2, TResult>: Represents a delegate that takes two input parameters (int, int)
            // and returns a value of type TResult (int). Used here for the Sum method.
            Func<int, int, int> fn = new Func<int, int, int>(g.Sum);
            Console.WriteLine(fn(10, 20));  // Outputs: 30

            // Action<T>: Represents a delegate that takes one parameter (string) and returns void.
            // Used here for the Greeting method.
            Action<string> greet = new Action<string>(g.Greeting);
            greet("Ram");  // Outputs: Happy Birthday Ram

            // Predicate<T>: Represents a delegate that takes one input parameter (int)
            // and returns a boolean. Commonly used for conditions.
            Predicate<int> checkEven = new Predicate<int>(g.IsEven);
            Console.WriteLine(checkEven(9));  // Outputs: False (9 is not even)
        }
    }
}
