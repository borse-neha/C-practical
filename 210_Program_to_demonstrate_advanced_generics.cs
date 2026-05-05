using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 210. Program to demonstrate advanced generics (generic constraints)
// Generated as a standalone sample file.
public class Repository<T> where T : class, new()
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }
}

public class Person
{
    public string Name { get; set; }
}

public class Problem210
{
    public static async Task Main()
    {
        Repository<Person> repo = new Repository<Person>();
        repo.Add(new Person { Name = "Alice" });
        repo.Add(new Person { Name = "Bob" });

        List<Person> people = repo.GetAll();
        foreach (var person in people)
        {
            Console.WriteLine($"Person: {person.Name}");
        }

        await Task.CompletedTask;
    }
}