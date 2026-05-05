using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 266. Program to demonstrate AR/VR simulation
// Generated as a standalone sample file.
public class ARVRSimulator
{
    public void RenderScene()
    {
        Console.WriteLine("Rendering AR/VR scene...");
        Console.WriteLine("Objects: Cube, Sphere");
    }

    public void Interact(string action)
    {
        Console.WriteLine($"Interacting: {action}");
    }
}

public class Problem266
{
    public static async Task Main()
    {
        ARVRSimulator sim = new ARVRSimulator();
        sim.RenderScene();
        sim.Interact("Touch cube");

        await Task.CompletedTask;
    }
}