using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 284. Program to demonstrate autonomous systems simulation
// Generated as a standalone sample file.
public class AutonomousCar
{
    public void Navigate(string destination)
    {
        Console.WriteLine($"Navigating to {destination} autonomously");
        Console.WriteLine("Checking sensors...");
        Console.WriteLine("Adjusting speed...");
        Console.WriteLine("Arrived at destination");
    }
}

public class Problem284
{
    public static async Task Main()
    {
        AutonomousCar car = new AutonomousCar();
        car.Navigate("Office");

        await Task.CompletedTask;
    }
}