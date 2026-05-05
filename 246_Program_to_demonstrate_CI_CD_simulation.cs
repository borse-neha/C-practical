using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 246. Program to demonstrate CI/CD simulation
// Generated as a standalone sample file.
public class CISimulation
{
    public void Build()
    {
        Console.WriteLine("Building project...");
    }

    public void Test()
    {
        Console.WriteLine("Running tests...");
    }

    public void Deploy()
    {
        Console.WriteLine("Deploying application...");
    }
}

public class Problem246
{
    public static async Task Main()
    {
        CISimulation ci = new CISimulation();
        ci.Build();
        ci.Test();
        ci.Deploy();

        await Task.CompletedTask;
    }
}