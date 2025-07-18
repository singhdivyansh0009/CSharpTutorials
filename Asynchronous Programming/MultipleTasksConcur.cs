using System;
using System.Threading.Tasks;

namespace AsyncProgrammingExample
{
    internal class Program
    {
        // This method simulates downloading a file asynchronously.
        // It takes a file name and delay duration, and returns the "content" after the delay.
        static async Task<string> DownloadFileAsync(string fileName, int delay)
        {
            Console.WriteLine($"Starting download: {fileName}");

            // Simulates an asynchronous operation like downloading or fetching from a server.
            await Task.Delay(delay); // Non-blocking delay — doesn't block the thread

            Console.WriteLine($"Completed download: {fileName}");

            // Returns simulated content after download
            return $"{fileName} content";
        }

        // Entry point of the program
        // This is an async Main method (supported from C# 7.1 onward),
        // allowing us to use await inside Main.
        static async Task Main(string[] args)
        {
            Console.WriteLine("Beginning downloads...");

            // Start three asynchronous download tasks concurrently.
            // These tasks start immediately and run in parallel (not one after another).
            Task<string> file1 = DownloadFileAsync("file1.txt", 2000);
            Task<string> file2 = DownloadFileAsync("file2.txt", 3000);
            Task<string> file3 = DownloadFileAsync("file3.txt", 1000);

            // Wait for all three tasks to complete.
            // This is efficient — we wait for all at once, not one by one.
            string[] results = await Task.WhenAll(file1, file2, file3);

            Console.WriteLine("All files downloaded!");

            // Print the content returned by each task
            foreach (string content in results)
            {
                Console.WriteLine($"Downloaded content: {content}");
            }

            Console.WriteLine("Continuing with other tasks...");
        }
    }
}
