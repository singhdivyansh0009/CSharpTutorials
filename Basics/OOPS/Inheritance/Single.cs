
using System;
class Vehicle{
    protected string type;
    protected int noOfWheels;
    protected string color;
}
// single level inheritance
class Car :  Vehicle{
    public Car(int w,string c){
        noOfWheels = w;
        color = c;
        type = "Car";
    }
    public void display(){
        Console.WriteLine("Type :"+type);
        Console.WriteLine("No. of wheels :"+ noOfWheels);
        Console.WriteLine("Color :"+ color);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Car c = new Car(4,"Red");
        c.display();
    }
}
