using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 247. Program to demonstrate version control simulation
// Generated as a standalone sample file.
public class VersionControl
{
    private List<string> commits = new List<string>();

    public void Commit(string message)
    {
        commits.Add(message);
        Console.WriteLine($"Committed: {message}");
    }

    public void Log()
    {
        Console.WriteLine("Commit history:");
        foreach (var commit in commits)
        {
            Console.WriteLine($"- {commit}");
        }
    }
}

public class Problem247
{
    public static async Task Main()
    {
        VersionControl vc = new VersionControl();
        vc.Commit("Initial commit");
        vc.Commit("Added feature");
        vc.Log();

        await Task.CompletedTask;
    }
}