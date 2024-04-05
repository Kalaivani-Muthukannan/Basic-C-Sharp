using System;
using System.Data.Common;
using System.Net.Mail;
using System.Reflection;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        DateTime dob=new DateTime(2021,8,10,10,40,32);

        Console.WriteLine("Days- "+dob.Day);
        Console.WriteLine("Month- "+dob.Month);
        Console.WriteLine("Year- "+dob.Minute);
        Console.WriteLine("Minute- "+dob.Minute);
        Console.WriteLine("Second- "+dob.Second);

        string chr=dob.ToString("yyyy/MM/dd hh:mm:ss tt");
        string [] n=chr.Split(new char[]{'/',':',' '});

        for(int i=n.Length-1;i>=0;i++)
        {
            Console.Write(n[i]+ " ");
        }
        Console.WriteLine(" ");

        Console.WriteLine("Enter the value in yyyy/MM/dd hh:mm:ss tt: ");
            DateTime date=new DateTime();
            bool temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd  hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date);

            while(temp)
            {
                Console.WriteLine("Invalid format");
                temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date);
            }

        Console.WriteLine("Year- "+date.Year);
        Console.WriteLine("Month- "+date.Month);
        Console.WriteLine("Days- "+date.Day);

    }

}
