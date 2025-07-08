using System;
using System.Threading;

namespace Syncronization
{
    internal class Program
    {
        // Creating a SemaphoreSlim with an initial count of 2 and max count of 2.
        // This means only 2 threads can enter the critical section at the same time.
        static SemaphoreSlim semaphore = new SemaphoreSlim(2, 2);

        // Method representing access to a shared resource
        static void SharedResource()
        {
            try
            {
                // Display message that the thread is waiting to acquire the semaphore
                Console.WriteLine($"{Thread.CurrentThread.Name} is waiting");

                // Wait() will block the thread if the semaphore count is 0 (i.e., limit reached)
                semaphore.Wait();

                // Once acquired, the thread proceeds to process
                Console.WriteLine($"{Thread.CurrentThread.Name} is Processing");

                // Simulate a delay to represent processing (e.g., using a resource)
                Thread.Sleep(5000); // 5 seconds

                // Processing done
                Console.WriteLine($"{Thread.CurrentThread.Name} is Completed");
            }
            finally
            {
                // Always release the semaphore after finishing the work
                // This allows another waiting thread to enter
                semaphore.Release();
            }
        }

        // Main method - entry point of the program
        static void Main(string[] args)
        {
            // Create and start 3 threads that will try to access the shared resource
            for (int i = 1; i <= 3; i++)
            {
                Thread T = new Thread(SharedResource); // Create a new thread
                T.Name = $"Thread{i}"; // Assign a name to the thread for tracking
                T.Start(); // Start the thread execution
            }
        }
    }
}
