using System;
using System.Text; // contains class like StringBuilder
public class StringConcept
{
    public static void Main(string[] args)
    {
        /*
        // both are same 
        string s1 = "Hello"; // alias of String class
        String s2 = "Hello"; // String class
        Console.WriteLine(s1 + " " + s2);
        */
        
        /*
        // string are immutable in c#
        string s = "Hello";
        Console.WriteLine(s);
        s ="World";  // new memory allocated to s
        Console.WriteLine(s);
        */
        
        /*
        // StringBuilder are mutable
        StringBuilder s = new StringBuilder();
        s.Append("hello");
        Console.WriteLine(s);
        s.Append("World"); // changes made in same memory location
        Console.WriteLine(s);
        */
        
        // String methods
        string s=" Hello,world,Divyansh";
        Console.WriteLine(s.Length);
        Console.WriteLine(s.ToUpper());
        Console.WriteLine(s.ToLower());
        Console.WriteLine(s.Trim());
        Console.WriteLine(s.Substring(2,3));
        Console.WriteLine(s.Replace("ell","ox"));
        string[] words = s.Split(",");
        for(int i = 0; i < words.Length; i++)
            Console.WriteLine(words[i]);
        Console.WriteLine(string.Join(" ",words));
        
    }
}
