using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 228. Program to demonstrate performance optimization basics
// Generated as a standalone sample file.
public class Problem228
{
    public static async Task Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            int x = i * 2;
        }
        stopwatch.Stop();
        Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");

        await Task.CompletedTask;
    }
}