using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 259. Program to demonstrate data migration simulation
// Generated as a standalone sample file.
public class DataMigrator
{
    public void Migrate(List<string> oldData, List<string> newData)
    {
        foreach (var item in oldData)
        {
            newData.Add(item.ToUpper());
        }
        Console.WriteLine("Data migrated successfully");
    }
}

public class Problem259
{
    public static async Task Main()
    {
        DataMigrator migrator = new DataMigrator();
        List<string> oldData = new List<string> { "data1", "data2" };
        List<string> newData = new List<string>();
        migrator.Migrate(oldData, newData);
        Console.WriteLine("New data: " + string.Join(", ", newData));

        await Task.CompletedTask;
    }
}