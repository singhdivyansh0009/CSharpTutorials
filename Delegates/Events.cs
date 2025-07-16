using System;

namespace Events
{
    // Step 1: Declare a delegate type.
    // Delegates define the signature of methods that can be attached to the event.
    public delegate void NotificationHandler(string s); // Custom delegate that returns void and takes a string

    // Class that raises an event
    class EventDemo
    {
        // Step 2: Declare an event using the delegate.
        // This event will notify subscribers when the work is completed.
        public event NotificationHandler WorkCompleted;

        public void DoSomeWork(string msg)
        {
            Console.WriteLine("Doing some work...");
            for (int i = 0; i < 1000; i++) ; // Simulated workload

            // Step 3: Raise the event (notify subscribers).
            // The null-conditional operator (?.) ensures no error if no method is subscribed.
            WorkCompleted?.Invoke(msg);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            EventDemo obj = new EventDemo();

            // Step 4: Subscribe to the event.
            // Here we attach a lambda expression that prints a message when the event is raised.
            obj.WorkCompleted += (msg) => Console.WriteLine("Event received: " + msg);

            // Calling method that raises the event
            obj.DoSomeWork("Work is done");
        }
    }
}
