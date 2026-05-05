using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

// 209. Program to demonstrate advanced reflection (dynamic method invocation)
// Generated as a standalone sample file.
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Problem209
{
    public static async Task Main()
    {
        Calculator calc = new Calculator();
        Type type = calc.GetType();

        // Invoke Add method dynamically
        MethodInfo addMethod = type.GetMethod("Add");
        int result1 = (int)addMethod.Invoke(calc, new object[] { 5, 3 });
        Console.WriteLine($"Add result: {result1}");

        // Invoke Multiply method dynamically
        MethodInfo multiplyMethod = type.GetMethod("Multiply");
        int result2 = (int)multiplyMethod.Invoke(calc, new object[] { 5, 3 });
        Console.WriteLine($"Multiply result: {result2}");

        await Task.CompletedTask;
    }
}