using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 265. Program to demonstrate IoT simulation
// Generated as a standalone sample file.
public class Sensor
{
    public string ReadData()
    {
        Random rand = new Random();
        return $"Temperature: {rand.Next(20, 30)} C";
    }
}

public class IoTDevice
{
    private Sensor sensor = new Sensor();

    public void CollectData()
    {
        string data = sensor.ReadData();
        Console.WriteLine($"Collected: {data}");
    }
}

public class Problem265
{
    public static async Task Main()
    {
        IoTDevice device = new IoTDevice();
        for (int i = 0; i < 5; i++)
        {
            device.CollectData();
            await Task.Delay(1000);
        }

        await Task.CompletedTask;
    }
}