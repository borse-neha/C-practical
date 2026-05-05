using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 253. Program to demonstrate backup simulation
// Generated as a standalone sample file.
public class BackupService
{
    public void BackupData(List<string> data)
    {
        // Mock backup to file
        File.WriteAllLines("backup.txt", data);
        Console.WriteLine("Data backed up to backup.txt");
    }
}

public class Problem253
{
    public static async Task Main()
    {
        BackupService backup = new BackupService();
        List<string> data = new List<string> { "Item1", "Item2", "Item3" };
        backup.BackupData(data);

        await Task.CompletedTask;
    }
}