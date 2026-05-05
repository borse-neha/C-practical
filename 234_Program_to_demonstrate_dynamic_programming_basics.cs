using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 234. Program to demonstrate dynamic programming basics
// Generated as a standalone sample file.
public class Problem234
{
    public static async Task Main()
    {
        dynamic d = 5;
        Console.WriteLine($"Type: {d.GetType()}, Value: {d}");
        d = "Hello";
        Console.WriteLine($"Type: {d.GetType()}, Value: {d}");
        d = new ExpandoObject();
        d.Name = "Dynamic";
        d.Age = 10;
        Console.WriteLine($"Name: {d.Name}, Age: {d.Age}");

        await Task.CompletedTask;
    }
}