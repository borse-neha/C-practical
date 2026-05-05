using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 272. Program to demonstrate DevOps simulation
// Generated as a standalone sample file.
public class DevOpsPipeline
{
    public void Build()
    {
        Console.WriteLine("Building code...");
    }

    public void Test()
    {
        Console.WriteLine("Running tests...");
    }

    public void Deploy()
    {
        Console.WriteLine("Deploying to production...");
    }

    public void RunPipeline()
    {
        Build();
        Test();
        Deploy();
    }
}

public class Problem272
{
    public static async Task Main()
    {
        DevOpsPipeline pipeline = new DevOpsPipeline();
        pipeline.RunPipeline();

        await Task.CompletedTask;
    }
}