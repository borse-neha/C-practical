using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 261. Program to demonstrate big data simulation
// Generated as a standalone sample file.
public class BigDataProcessor
{
    public void ProcessData(List<int> data)
    {
        long sum = data.Sum();
        double avg = data.Average();
        Console.WriteLine($"Processed {data.Count} items. Sum: {sum}, Avg: {avg}");
    }
}

public class Problem261
{
    public static async Task Main()
    {
        BigDataProcessor processor = new BigDataProcessor();
        List<int> data = Enumerable.Range(1, 100000).ToList();
        processor.ProcessData(data);

        await Task.CompletedTask;
    }
}