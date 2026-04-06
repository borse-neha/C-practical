using System;

class Armstrong
{
    static void Main()
    {
        int num, original, remainder, result = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        original = num;

        while (num != 0)
        {
            remainder = num % 10;
            result += remainder * remainder * remainder;
            num = num / 10;
        }

        if (original == result)
            Console.WriteLine("Number is Armstrong");
        else
            Console.WriteLine("Number is Not Armstrong");
    }
}