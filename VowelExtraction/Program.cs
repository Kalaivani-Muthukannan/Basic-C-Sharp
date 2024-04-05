using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        string input=Console.ReadLine();
        input=input.ToLower();
        for(int i=0; i<input.Length;i++)
        {
            if(input[i]=='a' || input[i]=='e' || input[i]=='i' || input[i]=='o' || input[i]=='u')
            {
                Console.WriteLine(input[i]);
            }
            else if(input[i]==' ')
            {
                Console.Write(" ");
            }
        }
    } 
}
