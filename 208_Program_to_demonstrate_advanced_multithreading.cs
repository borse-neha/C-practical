using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 208. Program to demonstrate advanced multithreading (parallel processing)
// Generated as a standalone sample file.
public class Problem208
{
    public static async Task Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Parallel processing
        Parallel.ForEach(numbers, number =>
        {
            Console.WriteLine($"Processing {number} on thread {Task.CurrentId}");
        });

        Console.WriteLine("Parallel processing completed.");

        await Task.CompletedTask;
    }
}