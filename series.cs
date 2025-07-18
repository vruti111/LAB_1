using System;
namespace LAB_1
{
    class series
    {
        public static void Main()
        {
            int[] fib = new int[11];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            foreach (int num in fib)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}