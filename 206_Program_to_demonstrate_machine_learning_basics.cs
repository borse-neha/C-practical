using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 206. Program to demonstrate machine learning basics (simple linear regression)
// Generated as a standalone sample file.
public class Problem206
{
    public static async Task Main()
    {
        // Simple linear regression example
        double[] x = { 1, 2, 3, 4, 5 };
        double[] y = { 2, 4, 6, 8, 10 };

        // Calculate slope and intercept
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
        int n = x.Length;
        for (int i = 0; i < n; i++)
        {
            sumX += x[i];
            sumY += y[i];
            sumXY += x[i] * y[i];
            sumX2 += x[i] * x[i];
        }
        double slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
        double intercept = (sumY - slope * sumX) / n;

        Console.WriteLine($"Slope: {slope}, Intercept: {intercept}");

        await Task.CompletedTask;
    }
}