using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number >= 0)
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"Square root of {number} is: {squareRoot}");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input number is too large or too small to be an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("Good Bye.");
    }
}