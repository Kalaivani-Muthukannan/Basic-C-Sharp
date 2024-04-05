using System;
using System.Diagnostics.CodeAnalysis;
namespace Assignment;
class Program
{

    public static void Main(string[] args)
    {
        Console.Write("Enter start value: ");
        int num1=int.Parse(Console.ReadLine());
        Console.Write("Enter end value: ");
        int num2=int.Parse(Console.ReadLine());
        int sumSquare = 0;
        for(int i=num1;i<num2;i++)
        {
            sumSquare=sumSquare+i*i; 
        }
        Console.WriteLine("Square between two num:"+sumSquare); 
    }
}