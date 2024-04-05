using System;
namespace Assignment;
class Program{
    public static void Main(string[] args)
    {
                double salary = Convert.ToDouble(Console.ReadLine());
                double da = 0.1 * salary;
                double hra = 0.1 * salary;

                
                double annualIncome = 12 * (salary + da + hra);
                double taxes = 0.05 * annualIncome;
                annualIncome = annualIncome - taxes;
                Console.WriteLine(annualIncome);

    }
}
