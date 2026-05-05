using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 232. Program to demonstrate delegates advanced (multicast)
// Generated as a standalone sample file.
public class Problem232
{
    public static async Task Main()
    {
        Action<int> action = (x) => Console.WriteLine($"First: {x}");
        action += (x) => Console.WriteLine($"Second: {x * 2}");
        action += (x) => Console.WriteLine($"Third: {x * 3}");

        action(5);

        await Task.CompletedTask;
    }
}