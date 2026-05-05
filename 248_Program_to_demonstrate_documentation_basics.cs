using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 248. Program to demonstrate documentation basics
/// This is a sample class with XML documentation.
/// </summary>
public class DocumentedClass
{
    /// <summary>
    /// Adds two numbers.
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Sum of a and b</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Problem248
{
    public static async Task Main()
    {
        DocumentedClass obj = new DocumentedClass();
        Console.WriteLine($"Sum: {obj.Add(2, 3)}");

        await Task.CompletedTask;
    }
}