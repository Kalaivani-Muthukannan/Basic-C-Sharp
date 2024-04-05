using System;
using System.Reflection;
using System.Xml.Schema;
namespace TypeConversion;
class Program
{

    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name=Convert.ToString(Console.ReadLine());

        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject1: ");
        float mark1=float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject2: ");
        float mark2=float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject3: ");
        float mark3=float.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        char grade=char.Parse(Console.ReadLine());

        Console.Write("Enter MobileNumber: ");
        long MobileNumber=long.Parse(Console.ReadLine());

        Console.Write("Enter Mail id: ");
        string mail=Convert.ToString(Console.ReadLine());

        float total=mark1+mark2+mark3;
        float average=total/3;

        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name:"+name);
        Console.WriteLine("Age:"+age);
        Console.WriteLine("Mobile:" +MobileNumber);
        Console.WriteLine("Mark1:" +mark1);
        Console.WriteLine("Mark2:" +mark2);
        Console.WriteLine("Mark3:" +mark3);
        Console.WriteLine("Total:" +total);
        Console.WriteLine("Average:"+average);
        Console.WriteLine("Grade: " +grade);
        Console.WriteLine("Mail id:" +mail);
        
    }
}
