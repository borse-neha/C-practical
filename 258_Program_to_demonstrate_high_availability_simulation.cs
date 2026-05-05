using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 258. Program to demonstrate high availability simulation
// Generated as a standalone sample file.
public class HACluster
{
    private List<string> nodes = new List<string> { "Node1", "Node2", "Node3" };
    private int activeNode = 0;

    public string GetActiveNode()
    {
        return nodes[activeNode];
    }

    public void Failover()
    {
        activeNode = (activeNode + 1) % nodes.Count;
        Console.WriteLine($"Failed over to {GetActiveNode()}");
    }
}

public class Problem258
{
    public static async Task Main()
    {
        HACluster cluster = new HACluster();
        Console.WriteLine($"Active node: {cluster.GetActiveNode()}");
        cluster.Failover();
        Console.WriteLine($"New active node: {cluster.GetActiveNode()}");

        await Task.CompletedTask;
    }
}