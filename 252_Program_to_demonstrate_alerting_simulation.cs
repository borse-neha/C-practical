using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 252. Program to demonstrate alerting simulation
// Generated as a standalone sample file.
public class Alerter
{
    public void AlertIf(double value, double threshold)
    {
        if (value > threshold)
        {
            Console.WriteLine($"Alert: Value {value} exceeded threshold {threshold}");
        }
        else
        {
            Console.WriteLine("No alert");
        }
    }
}

public class Problem252
{
    public static async Task Main()
    {
        Alerter alerter = new Alerter();
        alerter.AlertIf(80, 75);
        alerter.AlertIf(70, 75);

        await Task.CompletedTask;
    }
}