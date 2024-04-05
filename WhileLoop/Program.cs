using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        int i=0;
         while(i<=25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
        i++;
        }

        Console.Write("Enter the number: ");
        bool isValid=int.TryParse(Console.ReadLine(),out int output);
        while(!isValid)
        {
            Console.Write("Invalid Number. Enter again: ");
            isValid=int.TryParse(Console.ReadLine(),out output);
        }

       

    }
}
