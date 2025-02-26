using System;

namespace FractalPaul.Fibonacci {
public class Program
{
    // Iterative approach
    static long FibonacciIterative(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;

        long prev = 0;
        long current = 1;

        for (int i = 2; i <= n; i++)
        {
            long next = prev + current;
            prev = current;
            current = next;
        }
        return current;
    }

    // Recursive approach (less efficient for large numbers)
    static long FibonacciRecursive(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static void Main(string[] args)
    {
        //Console.WriteLine("Enter which Fibonacci number you'd like to calculate (n):");
        int n = 5;

       if (args.Length > 0)  {
         if (int.TryParse(args[0], out n)) {
            Console.WriteLine($"Calculating the {n}th Fibonacci number...");
         } else {
            Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
            return;
         }
       }
        // // Get and validate user input
        // while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        // {
        //     Console.WriteLine("Please enter a valid non-negative integer:");
        // }

        try
        {
            // Using iterative method 
            long result = FibonacciIterative(n);
            Console.WriteLine($"The {n}th Fibonacci number is: {result}");

            // Note: Recursive method is commented out as it can be very slow 
            // for larger numbers and may cause stack overflow
            // long resultRecursive = FibonacciRecursive(n);
            // Console.WriteLine($"Recursive result: {resultRecursive}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The result is too large to calculate with current data type.");
        }
    }
}
}