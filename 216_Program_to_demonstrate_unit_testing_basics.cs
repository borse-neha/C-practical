using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 216. Program to demonstrate unit testing basics (simulation)
// Generated as a standalone sample file.
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class TestCalculator
{
    public void TestAdd()
    {
        Calculator calc = new Calculator();
        int result = calc.Add(2, 3);
        Console.WriteLine($"Test Add: Expected 5, Got {result} - {(result == 5 ? "Pass" : "Fail")}");
    }

    public void TestSubtract()
    {
        Calculator calc = new Calculator();
        int result = calc.Subtract(5, 3);
        Console.WriteLine($"Test Subtract: Expected 2, Got {result} - {(result == 2 ? "Pass" : "Fail")}");
    }
}

public class Problem216
{
    public static async Task Main()
    {
        TestCalculator tester = new TestCalculator();
        tester.TestAdd();
        tester.TestSubtract();

        await Task.CompletedTask;
    }
}