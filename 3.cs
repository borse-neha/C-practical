using System;

class Calculator
{
    // Method for Addition
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Method for Subtraction
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Method for Multiplication
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Method for Division
    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        double num1, num2;
        int choice;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result = " + Add(num1, num2));
                break;

            case 2:
                Console.WriteLine("Result = " + Subtract(num1, num2));
                break;

            case 3:
                Console.WriteLine("Result = " + Multiply(num1, num2));
                break;

            case 4:
                Console.WriteLine("Result = " + Divide(num1, num2));
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.ReadLine();
    }
}
