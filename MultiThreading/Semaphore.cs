using System;
using System.Threading;

namespace Syncronization
{
    internal class Program
    {
        // Create a semaphore that allows a maximum of 2 threads to access the resource at the same time.
        // First parameter = initial count (2 threads can enter immediately)
        // Second parameter = maximum count (at most 2 threads can enter concurrently)
        static Semaphore semaphore = new Semaphore(2, 2);

        // This method simulates access to a shared resource
        static void SharedResource()
        {
            try
            {
                // Thread will attempt to enter the semaphore
                Console.WriteLine($"{Thread.CurrentThread.Name} is waiting");

                // WaitOne() decrements the semaphore count and waits if the count is 0
                semaphore.WaitOne(); 

                Console.WriteLine($"{Thread.CurrentThread.Name} is Processing");

                // Simulate some work being done
                Thread.Sleep(5000); // 5 seconds

                Console.WriteLine($"{Thread.CurrentThread.Name} is Completed");
            }
            finally
            {
                // Always release the semaphore so other waiting threads can enter
                semaphore.Release(); 
            }
        }

        // Main entry point of the program
        static void Main(string[] args)
        {
            // Spawning 3 threads that will all try to enter the shared resource
            for (int i = 1; i <= 3; i++)
            {
                Thread T = new Thread(SharedResource); // Create a new thread
                T.Name = $"Thread{i}"; // Assign a name for easier tracking in output
                T.Start(); // Start execution
            }
        }
    }
}
