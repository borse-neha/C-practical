using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 240. Program to demonstrate caching basics
// Generated as a standalone sample file.
public class Cache
{
    private Dictionary<string, object> cache = new Dictionary<string, object>();

    public void Set(string key, object value)
    {
        cache[key] = value;
    }

    public object Get(string key)
    {
        return cache.ContainsKey(key) ? cache[key] : null;
    }
}

public class Problem240
{
    public static async Task Main()
    {
        Cache cache = new Cache();
        cache.Set("key1", "value1");
        Console.WriteLine($"Cached value: {cache.Get("key1")}");

        await Task.CompletedTask;
    }
}