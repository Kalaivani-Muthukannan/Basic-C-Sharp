using System;
using System.Globalization;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
        string a=Console.ReadLine();
        string[] b=a.Split(" ");
        int[] arr=new int[num];
        for(int i=0;i<num;i++)
        {
            arr[i]=int.Parse(b[i]);
        }
        int maximum=arr[0];
        for(int i=0;i<num;i++)
        {
            if(arr[i]>maximum)
            {
                maximum=arr[i];
            }
        }
        Console.WriteLine(maximum);
    }
}