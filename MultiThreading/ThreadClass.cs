using System;
using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        // This method represents the first task to be executed on a separate thread
        static void Task1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Task1");

                // Simulate a blocking operation at the 3rd iteration
                if(i == 3)
                {
                    Console.WriteLine("Thread Slept");
                    Thread.Sleep(5000); // Pauses current thread for 5 seconds
                    Console.WriteLine("Thread Woke Up");
                }
            }
        }

        // This method represents the second task to be executed on a separate thread
        static void Task2()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Task2");
        }

        static void Main(string[] args)
        {
            // By default, if we call Task1() and Task2() like regular methods,
            // they will execute sequentially (one after another), not concurrently.

            // Thread class represents a thread of execution.
            // We create two threads, assigning Task1 and Task2 as their entry methods.
            Thread T1 = new Thread(Task1); // Thread T1 will run Task1
            Thread T2 = new Thread(Task2); // Thread T2 will run Task2

            // Start both threads — this initiates concurrent execution
            T1.Start(); // Starts Task1 on a new thread
            T2.Start(); // Starts Task2 on another thread

            // Output the details of the main thread
            Console.WriteLine(Thread.CurrentThread); // Displays main thread info
        }
    }
}
