using System;
namespace LAB_1
{
	public class mobile 
	{
			public static void Main(string[] args)	
		{
			Console.WriteLine("enter your mobile number:");
			string mobile = Console.ReadLine();
			string result = mobile.Substring(0,5) +"yyyyy";
			Console.WriteLine(result);
		}
	}
}
