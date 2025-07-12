using System;
namespace LAB_1
{
    public class toggle
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string result = "";

            foreach (char ch in input)
                result += char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);

            Console.WriteLine("Toggle Case: " + result);
        }
    }
}


