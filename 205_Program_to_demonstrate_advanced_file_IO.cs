using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 205. Program to demonstrate advanced file I/O (reading/writing JSON)
// Generated as a standalone sample file.
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Problem205
{
    public static async Task Main()
    {
        string filePath = "persons.json";
        List<Person> persons = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 }
        };

        // Serialize to JSON
        string json = System.Text.Json.JsonSerializer.Serialize(persons);
        await File.WriteAllTextAsync(filePath, json);
        Console.WriteLine("Data written to file.");

        // Deserialize from JSON
        string readJson = await File.ReadAllTextAsync(filePath);
        List<Person> readPersons = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(readJson);
        foreach (var person in readPersons)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        await Task.CompletedTask;
    }
}