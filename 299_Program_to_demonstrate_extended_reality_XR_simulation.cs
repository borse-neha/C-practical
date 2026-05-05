using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 299. Program to demonstrate extended reality (XR) simulation
// Generated as a standalone sample file.
public class XRPlatform
{
    public void SwitchMode(string mode)
    {
        Console.WriteLine($"Switching to {mode} mode (AR/VR/MR)");
    }

    public void IntegrateSenses(string sense)
    {
        Console.WriteLine($"Integrating {sense} for immersive XR experience");
    }
}

public class Problem299
{
    public static async Task Main()
    {
        XRPlatform xr = new XRPlatform();
        xr.SwitchMode("VR");
        xr.IntegrateSenses("haptic feedback");

        await Task.CompletedTask;
    }
}