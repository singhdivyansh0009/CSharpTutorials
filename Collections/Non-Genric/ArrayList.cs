using System.Collections; // Importing the namespace that contains ArrayList
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList instance
            ArrayList a = new ArrayList();

            // Add element '10' to the list
            a.Add(10);

            // Insert element '20' at index 1 (second position)
            a.Insert(1, 20); // Now the list is: [10, 20]

            // Add element '30' to the end of the list
            a.Add(30); // Now the list is: [10, 20, 30]

            // Print all elements using foreach loop
            Console.WriteLine("After adding elements:");
            foreach(object element in a){
                Console.WriteLine(element);
            }

            // Remove the first occurrence of element '10'
            a.Remove(10); // Now the list is: [20, 30]

            // Print all elements after removal
            Console.WriteLine("After removing 10:");
            foreach (object element in a)
            {
                Console.WriteLine(element);
            }

            // Remove the element at index 0 (removes 20)
            a.RemoveAt(0); // Now the list is: [30]

            // Print remaining elements using for loop
            Console.WriteLine("After removing element at index 0:");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
