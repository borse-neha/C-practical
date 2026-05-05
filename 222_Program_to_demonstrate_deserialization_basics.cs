using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// 222. Program to demonstrate deserialization basics
// Generated as a standalone sample file.
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Problem222
{
    public static async Task Main()
    {
        string json = "{\"Name\":\"Alice\",\"Age\":30}";
        Person person = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine($"Deserialized: {person.Name}, Age: {person.Age}");

        await Task.CompletedTask;
    }
}