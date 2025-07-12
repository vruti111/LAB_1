using System;

namespace LAB_1
{
    class Program3
    {
        static void Main(string[] args)
        {
            int a, b, c, result;

            Console.Write("Enter Number   1: ");
            string str = Console.ReadLine();      // ✅ Missing statement to read input as string
            a = Convert.ToInt32(str);

            Console.Write("Enter Number  2 : ");
            str = Console.ReadLine();             // ✅ Reuse variable to read second number
            b = Convert.ToInt32(str);

            Console.Write("Enter Number   3 : ");
            str = Console.ReadLine();             // ✅ Read third number
            c = Convert.ToInt32(str);             // ✅ Convert third number

            result = Sum(a, b, c);                // ✅ Call the Sum method with 3 parameters
            Console.WriteLine("Sum : {0}", result); // ✅ Print the result

            Console.Read();                       // Wait for user to press a key
        }

        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}
