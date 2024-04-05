using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        string a=Console.ReadLine();
        string b=string.Empty;
        int count=0;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]!=' ')
            {
                b=b+a[i];
                count++;
            }
        }
        Console.WriteLine("Modified string: "+b);
        Console.WriteLine("Modified string Length: "+count);

    }
}
