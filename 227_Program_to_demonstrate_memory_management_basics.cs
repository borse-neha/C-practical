using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 227. Program to demonstrate memory management basics
// Generated as a standalone sample file.
public class Problem227
{
    public static async Task Main()
    {
        Console.WriteLine("GC Collections before: " + GC.CollectionCount(0));
        for (int i = 0; i < 10000; i++)
        {
            object obj = new object();
        }
        GC.Collect();
        Console.WriteLine("GC Collections after: " + GC.CollectionCount(0));

        await Task.CompletedTask;
    }
}