using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 224. Program to demonstrate database basics (mock ADO.NET)
// Generated as a standalone sample file.
public class MockDatabase
{
    private List<string> data = new List<string>();

    public void Insert(string item)
    {
        data.Add(item);
        Console.WriteLine($"Inserted: {item}");
    }

    public List<string> SelectAll()
    {
        return data;
    }
}

public class Problem224
{
    public static async Task Main()
    {
        MockDatabase db = new MockDatabase();
        db.Insert("Item1");
        db.Insert("Item2");
        List<string> items = db.SelectAll();
        Console.WriteLine("All items: " + string.Join(", ", items));

        await Task.CompletedTask;
    }
}