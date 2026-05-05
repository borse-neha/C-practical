using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 245. Program to demonstrate container basics (mock)
// Generated as a standalone sample file.
public class Container
{
    public string Image { get; set; }
    public string Command { get; set; }

    public void Run()
    {
        Console.WriteLine($"Running container with image {Image} and command {Command}");
    }
}

public class Problem245
{
    public static async Task Main()
    {
        Container container = new Container { Image = "nginx", Command = "start" };
        container.Run();

        await Task.CompletedTask;
    }
}