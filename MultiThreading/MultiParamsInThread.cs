using System;
using System.Threading;

namespace MultiThreadingMultipleParams
{
    internal class Program
    {
        // This method takes two parameters — not directly supported by Thread constructor
        public static void PrintDetails(string name, int age)
        {
            Console.WriteLine("Thread Starts");
            Console.WriteLine($"Name: {name}, Age: {age}");
            Console.WriteLine("Thread Exiting");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Starts");

            // ✅ Creating a thread using a lambda expression
            // Thread constructor requires a parameterless method (ThreadStart delegate)
            // So we use a lambda expression to "wrap" the call to PrintDetails with arguments
            Thread thread = new Thread(() => PrintDetails("Divya", 22));

            // 🔁 The lambda captures both parameters and calls PrintDetails with them
            thread.Start(); // Starts the thread and executes the lambda

            Console.WriteLine("Main Thread Exiting");
        }
    }
}
