using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

// 237. Program to demonstrate code generation basics (reflection)
// Generated as a standalone sample file.
public class Problem237
{
    public static async Task Main()
    {
        Type type = typeof(string);
        MethodInfo method = type.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });
        string str = "Hello World";
        object result = method.Invoke(str, new object[] { 6, 5 });
        Console.WriteLine($"Result: {result}");

        await Task.CompletedTask;
    }
}