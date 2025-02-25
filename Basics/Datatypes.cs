
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i = 10; 
        uint i = 10;  // unsigned int
        char ch = 'a';
        bool isBool = true;
        double d = 1.23; // decimal precision with nearly 7
        float f = 1.23f; // decimal precision with nearly 15
        decimal dm = 1.233893; // decimal precision with nearly 28 - 29
        string s = "ABC"; // string 
        dynamic anyType = 1; // store any type but type resolved at runtime
        object obj = "a"; // store any type but type resolved at compile time
    }
}
