using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 291. Program to demonstrate digital twins simulation
// Generated as a standalone sample file.
public class DigitalTwin
{
    public string Status { get; set; } = "Normal";

    public void UpdateFromSensor(string sensorData)
    {
        if (sensorData.Contains("error"))
            Status = "Faulty";
        Console.WriteLine($"Digital twin updated: {Status}");
    }
}

public class Problem291
{
    public static async Task Main()
    {
        DigitalTwin twin = new DigitalTwin();
        twin.UpdateFromSensor("sensor data normal");
        twin.UpdateFromSensor("sensor data error");

        await Task.CompletedTask;
    }
}