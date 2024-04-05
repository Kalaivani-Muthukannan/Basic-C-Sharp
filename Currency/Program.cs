using System;
namespace Assignment;
class Program{
    public static void Main(string[] args)
    {
        double number=double.Parse(Console.ReadLine());
        double usd=number*1.22;
        double eur=number*1.27;
        double cny=number*8.79;

        Console.WriteLine(Math.Round(usd/100,2)+"USD");
        Console.WriteLine(Math.Round(eur/100,2)+"EUR");
        Console.WriteLine(Math.Round(cny/100,2)+"CNY");
        }
}
