using System;
namespace Assignment;
class Program
{
    public static void Main(string[] args)
    {
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();

        char[] ch1=str1.ToCharArray();
        char[] ch2=str1.ToCharArray();

        int count=0;
        for(int i=0;i<ch1.Length;i++)
        {
            for(int j=0;j<ch2.Length;j++)
            {
                if(ch1[i]==ch2[j])
                {
                    ch2[j]='0';
                    count++;
                }
            }
        }
        if(count==ch2.Length)
        {
            Console.WriteLine("Anagrams");
        }
        else{
            Console.WriteLine("Not Anagrams");
        }
        

    }
}
