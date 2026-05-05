using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 298. Program to demonstrate mixed reality simulation
// Generated as a standalone sample file.
public class MRDevice
{
    public void BlendRealVirtual(string realObject, string virtualObject)
    {
        Console.WriteLine($"Blending {realObject} with {virtualObject} in mixed reality");
    }

    public void UpdateHologram(string hologramId, string newData)
    {
        Console.WriteLine($"Updating hologram {hologramId} with {newData}");
    }
}

public class Problem298
{
    public static async Task Main()
    {
        MRDevice mr = new MRDevice();
        mr.BlendRealVirtual("table", "hologram");
        mr.UpdateHologram("holo1", "new info");

        await Task.CompletedTask;
    }
}