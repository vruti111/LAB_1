using System;
namespace LAB_1
{
	public class gender
	{
		public static void Main(string[] args)
		{
			Console.Write("enter your name: ");
			string name = Console.ReadLine();
            Console.Write("enter your gender (M/F): ");
			char gender = Convert.ToChar(Console.ReadLine().ToUpper());
			string prefix = (gender == 'M') ? "Mr." : "Miss. ";
			Console.WriteLine(" hy " + prefix + name);
        }
	}
}
