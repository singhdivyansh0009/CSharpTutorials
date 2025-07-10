using System;
using System.Threading;

class Program
{
    // Method to be executed by each thread
    static void SomeMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            // Print current thread's name and priority along with the loop counter
            Console.WriteLine($"Thread Name: {Thread.CurrentThread.Name} Thread Priority: {Thread.CurrentThread.Priority} Printing {i}");
        }
    }

    public static void Main(string[] args)
    {
        // Creating Thread T1 and assigning the method to run
        Thread T1 = new Thread(SomeMethod)
        {
            Name = "Thread1" // Naming the thread
        };

        // Creating Thread T2
        Thread T2 = new Thread(SomeMethod)
        {
            Name = "Thread2"
        };

        // Creating Thread T3
        Thread T3 = new Thread(SomeMethod)
        {
            Name = "Thread3"
        };

        // Setting thread priorities
        T1.Priority = ThreadPriority.Highest; // T1 gets the highest priority
        T2.Priority = ThreadPriority.Normal;  // T2 gets normal priority
        T3.Priority = ThreadPriority.Lowest;  // T3 gets the lowest priority

        // Starting the threads
        T1.Start(); // T1 begins execution
        T2.Start(); // T2 begins execution
        T3.Start(); // T3 begins execution
    }
}
