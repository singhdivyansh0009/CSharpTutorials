using System;
using System.Threading;

namespace MultiThreadingConstructors
{
    internal class Program
    {
        // This method matches the ThreadStart delegate (no parameters)
        public static void Method1()
        {
            Console.WriteLine("Thread T1 Starts");
            for (int i = 0; i < 50; i++)
                Console.WriteLine("Method1");
            Console.WriteLine("Thread T1 Exiting");
        }

        // This method matches the ParameterizedThreadStart delegate (takes object parameter)
        public static void Method2(object n)
        {
            Console.WriteLine("Thread T2 Starts");

            // Since parameter is passed as object, it needs to be converted to int
            int count = Convert.ToInt32(n);
            for (int i = 0; i < count; i++)
                Console.WriteLine("Method2");

            Console.WriteLine("Thread T2 Exiting");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Starts");

            // ✅ Using ThreadStart delegate — works with methods that have no parameters
            Thread T1 = new Thread(Method1);

            // ❌ This line would give a compile-time error because Method2 takes a parameter,
            // but Thread(ThreadStart) only supports parameterless methods:
            // Thread T2 = new Thread(Method2);

            // ✅ Correct way — use ParameterizedThreadStart for methods that take a single object parameter
            Thread T2 = new Thread(new ParameterizedThreadStart(Method2));

            // Start the threads
            T1.Start();      // No arguments passed — works fine
            T2.Start(50);    // Pass integer 50 as object — Method2 will cast it

            Console.WriteLine("Main Thread Exiting");
        }
    }
}
