using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 260. Program to demonstrate ETL simulation
// Generated as a standalone sample file.
public class ETLProcess
{
    public List<string> Extract()
    {
        return new List<string> { "raw1", "raw2", "raw3" };
    }

    public void Transform(List<string> data)
    {
        for (int i = 0; i < data.Count; i++)
        {
            data[i] = data[i].ToUpper() + "_transformed";
        }
    }

    public void Load(List<string> data)
    {
        Console.WriteLine("Loaded data: " + string.Join(", ", data));
    }
}

public class Problem260
{
    public static async Task Main()
    {
        ETLProcess etl = new ETLProcess();
        List<string> data = etl.Extract();
        etl.Transform(data);
        etl.Load(data);

        await Task.CompletedTask;
    }
}