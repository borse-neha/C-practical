using System;

class ASCIIValue
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        int ascii = (int)ch;

        Console.WriteLine("ASCII value = " + ascii);
    }
}