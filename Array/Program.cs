using System;
using System.Reflection.Metadata;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        int input=int.Parse(Console.ReadLine());
        string[] arr= new string[input];
        string searchName=string.Empty;
        bool val=true;
        int count=0;
        for(int i=0;i<input;i++)
        {
            arr[i]=Console.ReadLine();
        }
        Console.WriteLine("Enter Name of Peoples:");
        for(int i=0;i<input;i++)
        {
            Console.WriteLine(arr[i]);
        }
        searchName=Console.ReadLine();

        for(int i=0;i<arr.Length;i++)
        {
            if(searchName==arr[i])
            {
                Console.WriteLine("The name Present in array: ");
                val=false;
                count=Array.IndexOf(arr,searchName);
                Console.WriteLine(count);
            }
        }
        if(val)
        {
            Console.WriteLine("The name not present in array");
        }
        Console.WriteLine("Enter the name to be search: "); 
        string searchName2=Console.ReadLine();
        bool val1=true;
        foreach(string i in arr)
        {
            if(searchName2==i)
            {
                val1=false;
                Console.WriteLine(i);
            }
        }
        if(val1)
        {
            Console.WriteLine("The name is not present in arr");
        }
    }
        
}
        