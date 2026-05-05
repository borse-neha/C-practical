using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 289. Program to demonstrate fraud detection simulation
// Generated as a standalone sample file.
public class FraudDetector
{
    public bool IsFraudulent(double amount, string location)
    {
        if (amount > 10000 || location == "suspicious")
            return true;
        return false;
    }
}

public class Problem289
{
    public static async Task Main()
    {
        FraudDetector detector = new FraudDetector();
        Console.WriteLine($"Transaction 1 fraudulent: {detector.IsFraudulent(5000, "normal")}");
        Console.WriteLine($"Transaction 2 fraudulent: {detector.IsFraudulent(15000, "normal")}");

        await Task.CompletedTask;
    }
}