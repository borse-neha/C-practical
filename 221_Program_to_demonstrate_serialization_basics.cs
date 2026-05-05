using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// 221. Program to demonstrate serialization basics
// Generated as a standalone sample file.
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Problem221
{
    public static async Task Main()
    {
        Person person = new Person { Name = "Alice", Age = 30 };
        string json = JsonSerializer.Serialize(person);
        Console.WriteLine($"Serialized: {json}");

        await Task.CompletedTask;
    }
}