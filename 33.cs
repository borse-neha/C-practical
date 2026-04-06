using System;

class DoWhileDemo
{
    static void Main()
    {
        int i = 1;

        do
        {
            Console.WriteLine("Value: " + i);
            i++;
        } while (i <= 5);
    }
}