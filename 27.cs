using System;

class ConstReadonly
{
    const double pi = 3.14;
    readonly int number;

    public ConstReadonly()
    {
        number = 10;
    }

    static void Main()
    {
        ConstReadonly obj = new ConstReadonly();
        Console.WriteLine("Constant PI = " + pi);
        Console.WriteLine("Readonly number = " + obj.number);
    }
}