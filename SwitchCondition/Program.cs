using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number 1: ");
        int number1=int.Parse(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        int number2=int.Parse(Console.ReadLine());
        
        Console.Write("Enter the action to take: ");
        char ch=char.Parse(Console.ReadLine());
        switch (ch)
        {
            case '+':
            {
                Console.WriteLine(number1 + number2);
                break;
            }
            case '-':
            {
                Console.WriteLine(number1 - number2);
                break;
            }
            case '*':
            {
                Console.WriteLine(number1 * number2);
                break;
            }
            case '%':
            {
                Console.WriteLine(number1 % number2);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid");
                break;
            }
        }

    }
}