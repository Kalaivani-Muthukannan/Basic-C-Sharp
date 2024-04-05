using System;
using System.Runtime.InteropServices;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        bool temp = false;
        do
        {
        Console.Write("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        if(number%2==0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("odd");
        }
        Console.Write("Do you want to continue with another number:yes/no");
        string YesNo=Console.ReadLine();
        if(YesNo != "yes" && YesNo!="no")
        {
            Console.Write("Invalid input : Enter valid input :");
            YesNo = Console.ReadLine();
        }
        if(YesNo=="yes")
        {
            temp=true;
        }
        else
        {
            temp=false;
        }
        }while(temp);
    }
}