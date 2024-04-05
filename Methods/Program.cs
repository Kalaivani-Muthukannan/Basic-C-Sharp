using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        string get=string.Empty;
        bool value=false;
        do{
            Console.WriteLine("Enter number for operation: ");
            int get1;
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());

            get1=int.Parse(Console.ReadLine());
            switch(get1)
            {
                case 1:
                {
                    Console.WriteLine(Addition(num1,num2));
                    break;
                }
                case 2:
                {
                    Console.WriteLine(Subtact(num1,num2));
                    break;
                }
                case 3:
                {
                    Console.WriteLine(Multiply(num1,num2));
                    break;
                }
                case 4:
                {
                    Console.WriteLine(Divide(num1,num2));
                    break;
                }
                
            }
            Console.WriteLine("Do you want to Continue: ");
            get=Console.ReadLine();
            do{
                if(get!="yes" && get!="no")
                {
                    Console.WriteLine("Enter valid Format");
                    value=true;
                    get=Console.ReadLine();
                }
                else if(get=="no")
                {
                    break;
                }
            }while(value);
        }while(get=="yes");
        static int Addition(int num1,int num2)
        {
            return num1+num2;
        }
        static int Subtact(int num1,int num2)
        {
            return num1-num2;
        }
        static int Multiply(int num1,int num2)
        {
            return num1*num2;
        }
        static int Divide(int num1,int num2)
        {
            return num1/num2;
        }

    }
}
