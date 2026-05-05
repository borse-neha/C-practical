using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 254. Program to demonstrate recovery simulation
// Generated as a standalone sample file.
public class RecoveryService
{
    public List<string> RecoverData()
    {
        if (File.Exists("backup.txt"))
        {
            return new List<string>(File.ReadAllLines("backup.txt"));
        }
        return new List<string>();
    }
}

public class Problem254
{
    public static async Task Main()
    {
        RecoveryService recovery = new RecoveryService();
        List<string> data = recovery.RecoverData();
        Console.WriteLine("Recovered data: " + string.Join(", ", data));

        await Task.CompletedTask;
    }
}