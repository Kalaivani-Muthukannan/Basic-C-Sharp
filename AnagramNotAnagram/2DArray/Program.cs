using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        int input=int.Parse(Console.ReadLine());
        int[,] arr=new int[3,3];

        for(int i=0;i<input;i++)
        {
            for(int j=0;j<input;j++)
            {
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i=0;i<input;i++)
        {
            for(int j=0;j<input;j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }

    }
}


