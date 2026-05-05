using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

// 233. Program to demonstrate expression trees basics
// Generated as a standalone sample file.
public class Problem233
{
    public static async Task Main()
    {
        Expression<Func<int, int>> expr = x => x * 2;
        Func<int, int> func = expr.Compile();
        Console.WriteLine($"Result: {func(5)}");

        await Task.CompletedTask;
    }
}