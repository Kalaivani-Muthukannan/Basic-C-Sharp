using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter tha main string:");
        string main=Console.ReadLine();
        Console.WriteLine("Enter the string to be searched:");
        string search=Console.ReadLine();

        int count=0;
        string[] str=main.Split(search);
        for(int i=0;i<search.Length;i++)
        {
            count = +search.Length;
        }
        Console.WriteLine(count);
    }
}
