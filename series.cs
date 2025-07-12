using System;
namespace LAB_1
{
    public class series
    {
        public static void Main(string[]args)
        {
            int n = 11, a = 0, b = 1, c;
            Console.Write(a + "" + b + "");
            for (int i= 2; i < n; i++) ;
            c = a + b;
            Console.Write(c + "");
            a = b;
            b = c;
        }
    }
}


