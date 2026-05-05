using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 268. Program to demonstrate mobile app simulation
// Generated as a standalone sample file.
public class MobileApp
{
    public void DisplayScreen(string screen)
    {
        Console.WriteLine($"Displaying {screen} screen");
    }

    public void HandleTap(string button)
    {
        Console.WriteLine($"Tapped {button}");
    }
}

public class Problem268
{
    public static async Task Main()
    {
        MobileApp app = new MobileApp();
        app.DisplayScreen("Home");
        app.HandleTap("Login");

        await Task.CompletedTask;
    }
}