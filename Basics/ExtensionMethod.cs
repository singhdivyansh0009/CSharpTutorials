using System;

// ✅ Rule 1: The class must be static
static class ExtensionMethod 
{
    // ✅ Rule 2: The method must be static
    // ✅ Rule 3: The first parameter must be prefixed with `this` keyword
    // ✅ Rule 4: The type of the first parameter (here, string) is the type being extended
    public static bool CheckPalindrome(this string s)
    {
        int n = s.Length;
        // Logic to check palindrome
        for (int i = 0, j = n - 1; i < j; i++, j--)
        {
            if (s[i] != s[j])
                return false;
        }
        return true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Taking input from user
        string s = Console.ReadLine();

        // ✅ At compile time, this is converted to: ExtensionMethod.CheckPalindrome(s);
        if (s.CheckPalindrome())
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
