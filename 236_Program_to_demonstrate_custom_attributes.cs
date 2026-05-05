using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 236. Program to demonstrate custom attributes
// Generated as a standalone sample file.
[AttributeUsage(AttributeTargets.Class)]
public class DescriptionAttribute : Attribute
{
    public string Description { get; }

    public DescriptionAttribute(string description)
    {
        Description = description;
    }
}

[Description("This is a test class")]
public class TestClass
{
    public void Display()
    {
        Console.WriteLine("Test class method");
    }
}

public class Problem236
{
    public static async Task Main()
    {
        TestClass obj = new TestClass();
        obj.Display();

        var attr = (DescriptionAttribute)Attribute.GetCustomAttribute(typeof(TestClass), typeof(DescriptionAttribute));
        if (attr != null)
        {
            Console.WriteLine($"Description: {attr.Description}");
        }

        await Task.CompletedTask;
    }
}