using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 295. Program to demonstrate future tech simulation
// Generated as a standalone sample file.
public class HologramProjector
{
    public void Project(string content)
    {
        Console.WriteLine($"Projecting hologram: {content}");
    }
}

public class Problem295
{
    public static async Task Main()
    {
        HologramProjector projector = new HologramProjector();
        projector.Project("3D model of future city");

        await Task.CompletedTask;
    }
}