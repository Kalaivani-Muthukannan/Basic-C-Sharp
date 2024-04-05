using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        if(n<=0)
        {
            Console.WriteLine(n==0?0: "Error");
        }
        else{
            int nth=n*n;
            Console.WriteLine(nth);
        }
    }
}