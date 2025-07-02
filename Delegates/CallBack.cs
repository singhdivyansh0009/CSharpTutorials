using System;
using System.Threading; // Needed for Thread.Sleep

namespace Delegates
{
    // Declare a delegate that matches methods with no parameters and void return type
    public delegate void NotificationDelegates();

    class CallBackDemo
    {
        // This method simulates doing some work and then calls the callback delegate
        public void DoWork(NotificationDelegates Notify)
        {
            Console.WriteLine("Working...");

            // Simulate some delay (e.g., long-running task)
            Thread.Sleep(2000); // Wait for 2 seconds

            // Callback to notify once the work is complete
            Notify();
        }

        // This is the method that can be passed as a callback
        public void Notify()
        {
            Console.WriteLine("Work is done");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CallBackDemo demo = new CallBackDemo();

            // Create a delegate instance pointing to Notify method
            NotificationDelegates callback = demo.Notify;

            // Start work and pass the callback
            demo.DoWork(callback);
        }
    }
}
