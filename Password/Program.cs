using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        string word=Console.ReadLine();
        bool value=true;
        if(word.Equals("s3cr3t!P@ssw0rd"))
        {
            Console.WriteLine("Welcome");
        }
        else{
            Console.WriteLine("Wrong password!");
        }
    }
}