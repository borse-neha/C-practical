using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 251. Program to demonstrate monitoring basics
// Generated as a standalone sample file.
public class Monitor
{
    public void LogMetric(string metric, double value)
    {
        Console.WriteLine($"{metric}: {value}");
    }
}

public class Problem251
{
    public static async Task Main()
    {
        Monitor monitor = new Monitor();
        monitor.LogMetric("CPU Usage", 75.5);
        monitor.LogMetric("Memory Usage", 60.2);

        await Task.CompletedTask;
    }
}