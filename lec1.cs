using System;
using System.Linq;
namespace LAB_1
{
	public class lec1
	{
		public static void Main(string[] args)

		{
			int[] a = { 1, 2, 5, 3, 4, 10, 20, 11, 12 };

			Console.WriteLine("MAx number:"+a.Max());
			Console.WriteLine("Min number:"+a.Min());

			var reverse = a.Reverse();
			Console.WriteLine("--------------------is");
			foreach (int i in reverse)
			{
				Console.Write(i + " ");
			}
			Array.Sort(a);
            Console.WriteLine("\nSorted is :");
            foreach (int i in a)
                Console.Write(i + " ");
        }
	}
}
