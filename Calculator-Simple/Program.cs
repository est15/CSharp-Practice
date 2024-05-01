using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Calculator_Simple
{
    internal class Program
    {
        // Method to Perform and Return the Math
        static string performMath(int num1, int num2, string operation)
        {
            if (operation == "+")
            {
                return Convert.ToString(num1 + num2);
            }
            else if (operation == "-")
            {
                return Convert.ToString(num1 - num2);
            }
            else if (operation == "*")
            {
                return Convert.ToString(num1 * num2);
            }
            else if (operation == "/")
            {
                return Convert.ToString(num1 / num2);
            }
            else
            {
                return Convert.ToString(num1 % num2);
            }
        }
        static void Main(string[] args)
        {
            string titleBanner = "[*][*]";
            Console.WriteLine("{0} Simple Calculator: {1}", titleBanner, titleBanner);

            // Set While Loop Variable
            var count = true;

            // While to Execute while count is false
            while (count)
            {
                try
                {
                    Console.WriteLine(
                    @"
----------------------------------
Enter Your Desired Operation:
    Ex: 4 % 2
----------------------------------
    * Add (+)
    * Subtract (-)
    * Multiply (*)
    * Divide (/)
    * Modulo (%)
    * Exit (exit)
                    ");

                    Console.Write("Operation: ");
                    string input = Console.ReadLine();

                    if (input == "exit" || input == "Exit")
                    {
                        // Exit the Application
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        // Splitting User Nums into Variable
                        string[] numbers = input.Split(' ');

                        // Declare the Numbers
                        int num1 = Convert.ToInt32(numbers[0]);
                        int num2 = Convert.ToInt32(numbers[2]);
                        string operation = Convert.ToString(numbers[1]);

                        // Send it all to the Math Function & Print 
                        Console.WriteLine("Answer: {0}", performMath(num1, num2, operation));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error with Input");
                }
            }
        }
    }
}