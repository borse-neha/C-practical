using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }

        Console.ReadLine();
    }
}
