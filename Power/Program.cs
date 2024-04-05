using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int input1=int.Parse(Console.ReadLine());
                int input2=int.Parse(Console.ReadLine());
                int power=1;
                int count=0;
                do
                {
                    power=power*input1;
                    count++;
                }while(count < input2);
                Console.WriteLine(power);
            }
        }
