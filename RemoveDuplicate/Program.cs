using System;
namespace Assignment;
class Program{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char[] ch=str.ToCharArray();
        for(int i=0;i<ch.Length;i++)
        {
            for(int j=i+1;j<ch.Length;j++)
            {
                if(ch[i]==ch[j])
                {
                    ch[j]='0';
                }
            }
            if(ch[i]!='0')
            {
                Console.Write(ch[i]);
            }
        }
    }
}