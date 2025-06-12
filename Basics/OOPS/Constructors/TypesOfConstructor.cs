
using System;
class Constructor{
    public int i;
    public static int j;
    public Constructor(int i){  // parameterized constructor
        this.i = i;
    }
    public Constructor(Constructor obj){ // copy constructor
        i = obj.i;
    }
    // static constructor called even before the main function
    // it should not have access modifiers, parameters and cannot be explicitly called
    // used to initialize the static members
    static Constructor(){ 
       Console.WriteLine("Static Constructor called"); 
       j = 20;
    }
    
}
class PrivateConstructor{
    // private constructor 
    private PrivateConstructor(){
         Console.WriteLine("This is Private Constructor");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // instance cannot be created outside the class for the class have private constructor
        // PrivateConstructor obj = new PrivateConstructor();
        Constructor obj1 = new Constructor(10);
        Console.WriteLine(obj1.i);
        Constructor obj2 = new Constructor(obj1);
        Console.WriteLine(obj2.i);
        Console.WriteLine(Constructor.j);
    }
}
