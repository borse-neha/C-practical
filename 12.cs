using System;

class Fibonacci
{
    static void Main()
    {
        int n, first = 0, second = 1, next;

        Console.Write("Enter number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write(first + " " + second + " ");

        for (int i = 3; i <= n; i++)
        {
            next = first + second;
            Console.Write(next + " ");
            first = second;
            second = next;
        }
    }
}