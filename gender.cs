using System;
namespace LAB_1
{
    public class gender
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("write your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your gender (M/F)");
            char gender = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            switch (gender)
            {
                case 'M':
                    Console.WriteLine("mr. " + name);
                    break;
                case 'F':
                    Console.WriteLine("ms. " + name);
                    break;
                default:
                    Console.Write("gender is missing.");
                    break;
            }
        }
    }
}
