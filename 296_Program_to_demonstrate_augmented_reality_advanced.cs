using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 296. Program to demonstrate augmented reality advanced
// Generated as a standalone sample file.
public class ARAssistant
{
    public void OverlayInfo(string realWorldObject)
    {
        Console.WriteLine($"Overlaying information on {realWorldObject}: Distance 5m, Details available");
    }

    public void TrackObject(string objectId)
    {
        Console.WriteLine($"Tracking object {objectId} in AR space");
    }
}

public class Problem296
{
    public static async Task Main()
    {
        ARAssistant ar = new ARAssistant();
        ar.OverlayInfo("building");
        ar.TrackObject("obj123");

        await Task.CompletedTask;
    }
}