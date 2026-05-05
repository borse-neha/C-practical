using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 280. Program to demonstrate edge computing simulation
// Generated as a standalone sample file.
public class EdgeDevice
{
    public void ProcessDataLocally(string data)
    {
        string processed = data.ToUpper();
        Console.WriteLine($"Processed locally: {processed}");
    }

    public void SendToCloud(string data)
    {
        Console.WriteLine($"Sending to cloud: {data}");
    }
}

public class Problem280
{
    public static async Task Main()
    {
        EdgeDevice device = new EdgeDevice();
        device.ProcessDataLocally("sensor data");
        device.SendToCloud("aggregated data");

        await Task.CompletedTask;
    }
}