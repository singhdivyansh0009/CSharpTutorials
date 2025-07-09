using System;
using System.Threading;

public class Program
{
    // CountdownEvent is initialized with a count of 10,
    // meaning it will wait for 10 calls to Signal() before unblocking.
    static CountdownEvent countdown = new CountdownEvent(10);

    // This is the method that will be called by each thread pool thread.
    // It prints information about the current thread, then signals the countdown.
    static void Method1(object obj)
    {
        Thread thread = Thread.CurrentThread;

        // Construct and print a message showing thread details.
        string message = $"Background: {thread.IsBackground}, " +
                         $"Thread Pool: {thread.IsThreadPoolThread}, " +
                         $"Thread ID: {thread.ManagedThreadId}";
        Console.WriteLine(message);

        // Decrease the countdown by 1. After 10 calls, countdown.Wait() will unblock.
        countdown.Signal();
    }

    public static void Main(string[] args)
    {
        // You can use this block instead of ThreadPool if you want dedicated threads.
        /*
        for(int i = 1; i <= 10; i++)
        {
            Thread T = new Thread(()=>Method1(null); 
            T.Start(); 
        }
        */

        // Loop to queue 10 tasks to the ThreadPool
        for (int i = 1; i <= 10; i++)
        {
            // Create a WaitCallback delegate pointing to Method1
            WaitCallback wc = new WaitCallback(Method1);

            // Queue the work item into the ThreadPool
            ThreadPool.QueueUserWorkItem(wc);
        }

        // Main thread waits until all 10 thread pool tasks call Signal()
        countdown.Wait();

        // Optionally print after all threads have finished
        Console.WriteLine("All threads completed.");
    }
}
