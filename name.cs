using System;
namespace LAB_1
{
	public class name 
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter your name:  ");
			string name = Console.ReadLine();
			Console.WriteLine("name: " +name);
		}
	}

}
/*using System;
class Program
{
    static void Main()
    {
        int a = 0, b = 1, c;
        Console.Write($"{a} {b} ");
        for (int i = 2; i < 11; i++)
        {
            c = a + b;
            Console.Write($"{c} ");
            a = b;
            b = c;
        }
    }
}



using System;
class Program {
    static void Main() {
        Console.Write("Enter number: ");
        string num = Console.ReadLine();
        string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        foreach (char c in num) {
            int digit = c - '0';
            Console.Write(words[digit] + " ");
        }
    }
}

using System;
class Program {
    static void Main() {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0, temp = num;
        while (temp > 0) {
            int digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }
        if (sum == num)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}

using System;
class Program {
    static void Main() {
        for (int i = 1; i <= 4; i++) {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}

using System;
class Program {
    static void Main() {
        for (int i = 1; i <= 4; i++) {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}

using System;
class Program {
    static void Main() {
        for (int i = 1; i <= 4; i++) {
            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");
            Console.WriteLine();
        }
    }
}*/


