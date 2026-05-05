using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 294. Program to demonstrate sustainability tech simulation
// Generated as a standalone sample file.
public class CarbonTracker
{
    public double TrackEmissions(double activity)
    {
        return activity * 0.5; // Mock calculation
    }

    public void SuggestReduction(double emissions)
    {
        Console.WriteLine($"Emissions: {emissions} kg CO2. Suggestion: Reduce usage by 20%");
    }
}

public class Problem294
{
    public static async Task Main()
    {
        CarbonTracker tracker = new CarbonTracker();
        double emissions = tracker.TrackEmissions(100);
        tracker.SuggestReduction(emissions);

        await Task.CompletedTask;
    }
}