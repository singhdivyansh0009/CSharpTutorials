using System;
using System.Threading;

namespace Syncronization
{
    internal class Program
    {
        // Declares a static Mutex object to be shared by all threads
        static Mutex mutex = new Mutex();

        // Method to simulate access to a shared resource
        static void SharedResource()
        {
            try
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is waiting");

                // WaitOne() blocks the thread until it can acquire the mutex
                mutex.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} is Processing");

                // Simulates some processing time
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} is Completed");
            }
            finally
            {
                // Releases the mutex so that another thread can acquire it
                mutex.ReleaseMutex();
            }
        }

        // Main method where program execution begins
        static void Main(string[] args)
        {
            // Creating and starting 3 threads to access the shared resource
            for (int i = 1; i <= 3; i++)
            {
                Thread T = new Thread(SharedResource); // Create new thread
                T.Name = $"Thread{i}"; // Assign a name to the thread
                T.Start(); // Start the thread
            }
        }
    }
}
