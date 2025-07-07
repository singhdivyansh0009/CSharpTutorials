using System;
using System.Threading;

namespace Syncronization
{
    internal class Program
    {
        // This is the lock object used to synchronize access to the shared resource.
        // It's static so that all threads share the same lock object.
        static readonly object lockObject = new object();

        // This method simulates accessing a shared resource.
        static void SharedResource()
        {
            // lock ensures that only one thread at a time can enter this block.
            // Without this, threads might interleave and corrupt the output.
            lock (lockObject)
            {
                Console.Write("This is ");
                Thread.Sleep(2000); // Simulate some work being done
                Console.Write("Shared Resource\n");
            }

            /*
            // ❌ Version without lock (leads to interleaved output):
            Console.Write("This is ");
            Thread.Sleep(2000); // Simulate some work
            Console.Write("Shared Resource\n");
            */
        }

        static void Main(string[] args)
        {
            // Creating two threads that both access the shared resource
            Thread t1 = new Thread(SharedResource);
            Thread t2 = new Thread(SharedResource);

            // Starting both threads
            t1.Start();
            t2.Start();

            // Optional: Wait for both threads to complete
            t1.Join();
            t2.Join();
        }
    }
}
