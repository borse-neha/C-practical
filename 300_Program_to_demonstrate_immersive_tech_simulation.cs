using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 300. Program to demonstrate immersive tech simulation
// Generated as a standalone sample file.
public class ImmersiveSystem
{
    public void CreateImmersiveExperience(string theme)
    {
        Console.WriteLine($"Creating immersive experience with theme: {theme}");
    }

    public void MonitorUserEngagement()
    {
        Console.WriteLine("Monitoring user engagement in immersive environment");
    }
}

public class Problem300
{
    public static async Task Main()
    {
        ImmersiveSystem immersive = new ImmersiveSystem();
        immersive.CreateImmersiveExperience("space exploration");
        immersive.MonitorUserEngagement();

        await Task.CompletedTask;
    }
}