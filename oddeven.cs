﻿using System;

public class oddeven
{
	static void Main()
	{
		Console.Write("enter a number:");
		int number = Convert.ToInt32(Console.ReadLine());
		if (number % 2 == 0)
			Console.WriteLine("the number is even");
		else
            Console.WriteLine("the number is odd");
    }
}



