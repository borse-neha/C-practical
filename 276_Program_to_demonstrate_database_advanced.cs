using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 276. Program to demonstrate database advanced
// Generated as a standalone sample file.
public class AdvancedDatabase
{
    private Dictionary<string, string> db = new Dictionary<string, string>();

    public void Insert(string key, string value)
    {
        db[key] = value;
        Console.WriteLine($"Inserted {key}: {value}");
    }

    public string Query(string key)
    {
        return db.ContainsKey(key) ? db[key] : "Not found";
    }

    public void Update(string key, string value)
    {
        if (db.ContainsKey(key))
        {
            db[key] = value;
            Console.WriteLine($"Updated {key}: {value}");
        }
    }

    public void Delete(string key)
    {
        if (db.Remove(key))
        {
            Console.WriteLine($"Deleted {key}");
        }
    }
}

public class Problem276
{
    public static async Task Main()
    {
        AdvancedDatabase db = new AdvancedDatabase();
        db.Insert("user1", "John");
        Console.WriteLine($"Query user1: {db.Query("user1")}");
        db.Update("user1", "Jane");
        db.Delete("user1");

        await Task.CompletedTask;
    }
}