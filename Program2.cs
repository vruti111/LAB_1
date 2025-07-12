using System; // Importing the System namespace for input/output functions

namespace LAB_1 // Defining a namespace named ConsoleApplication1
{
    class Program2 // Declaring a class named Program
    {
        static void Main(string[] args) // Main method: Entry point of the program
        {
            int n, fact = 1; // Declaring two integers: 'n' for input number, 'fact' initialized to 1 for factorial result

            Console.WriteLine("Enter Number : "); // Asking user to enter a number

            string str = Console.ReadLine(); // Reading user input as string

            n = Convert.ToInt32(str); // Converting string input to integer and storing it in 'n'

            for (int i = 1; i <= n; i++) // For loop to calculate factorial from 1 to n
            {
                fact = fact * i; // Multiplying current 'fact' with loop index 'i' to build factorial
            }

            Console.WriteLine("Factorial : {0}", fact); // Printing the calculated factorial

            Console.Read(); // Waiting for a key press to keep the console open
        }
    }
}
