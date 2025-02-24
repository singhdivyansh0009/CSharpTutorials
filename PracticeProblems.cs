// First n prime no.
using System;  

public class PrimeNumber
{
    private static bool isPrime(int n){
        if(n < 2 || n % 2 == 0)  return false;
        for(int i = 2; i <= Math.Sqrt(n); i++){
            if(n%i==0)
              return false;
        }
        return true;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first what No. of prime no. you want");
        int n = int.Parse(Console.ReadLine());  
        int i = 1;
        int count = 1;
        while(count <= n){
            if(isPrime(i)){
                Console.Write(i+" ");
                count++;
            }
            i++;
        }
       
    }
}
