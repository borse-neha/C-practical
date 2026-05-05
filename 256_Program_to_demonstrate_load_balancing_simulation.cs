using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 256. Program to demonstrate load balancing simulation
// Generated as a standalone sample file.
public class LoadBalancer
{
    private List<string> servers = new List<string> { "Server1", "Server2", "Server3" };
    private int current = 0;

    public string GetServer()
    {
        string server = servers[current];
        current = (current + 1) % servers.Count;
        return server;
    }
}

public class Problem256
{
    public static async Task Main()
    {
        LoadBalancer lb = new LoadBalancer();
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Request {i + 1} routed to {lb.GetServer()}");
        }

        await Task.CompletedTask;
    }
}