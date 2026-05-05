using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 249. Program to demonstrate testing frameworks simulation
// Generated as a standalone sample file.
public class Calculator
{
    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
}

public class TestFramework
{
    public void AssertEqual(int expected, int actual, string testName)
    {
        if (expected == actual)
        {
            Console.WriteLine($"{testName}: Pass");
        }
        else
        {
            Console.WriteLine($"{testName}: Fail - Expected {expected}, Got {actual}");
        }
    }

    public void AssertThrows<T>(Action action, string testName) where T : Exception
    {
        try
        {
            action();
            Console.WriteLine($"{testName}: Fail - Expected exception {typeof(T)}");
        }
        catch (T)
        {
            Console.WriteLine($"{testName}: Pass");
        }
    }
}

public class Problem249
{
    public static async Task Main()
    {
        Calculator calc = new Calculator();
        TestFramework test = new TestFramework();
        test.AssertEqual(2, calc.Divide(4, 2), "Divide positive");
        test.AssertThrows<DivideByZeroException>(() => calc.Divide(4, 0), "Divide by zero");

        await Task.CompletedTask;
    }
}