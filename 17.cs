using System;

class CountDigits
{
    static void Main()
    {
        int num, count = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            num /= 10;
            count++;
        }

        Console.WriteLine("Total digits = " + count);
    }
}