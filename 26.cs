using System;

class TypeCastingDemo
{
    static void Main()
    {
        double num = 9.78;
        int intNum = (int)num;   // Explicit casting

        Console.WriteLine("Double value: " + num);
        Console.WriteLine("Integer value: " + intNum);
    }
}