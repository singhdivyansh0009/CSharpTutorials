using System;

class Test{
    static int x=10;
    int y = 10;
    static Test(){
       Console.WriteLine("constructor called"); // called only once 
    }
    public static void print(){
        // we cannot use non static member in static method directly
        // Console.WriteLine("Value of y :" + y); 
        
        // but accessible using object of that class
        Test t = new Test();
        Console.WriteLine("Value of y :" + t.y); 
        Console.WriteLine("Value of x :" + x);
    }
}
public class StaticDemo
{
    public static void Main(string[] args)
    {
        Test t1 = new Test();
        Test t2 = new Test();
        Test.print(); 
    }
}
