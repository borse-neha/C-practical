using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 290. Program to demonstrate predictive analytics simulation
// Generated as a standalone sample file.
public class PredictiveModel
{
    public double Predict(double input)
    {
        // Simple linear prediction
        return input * 1.5 + 10;
    }
}

public class Problem290
{
    public static async Task Main()
    {
        PredictiveModel model = new PredictiveModel();
        Console.WriteLine($"Prediction for 5: {model.Predict(5)}");
        Console.WriteLine($"Prediction for 10: {model.Predict(10)}");

        await Task.CompletedTask;
    }
}