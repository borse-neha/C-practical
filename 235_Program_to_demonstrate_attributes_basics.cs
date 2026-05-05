using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 235. Program to demonstrate attributes basics
// Generated as a standalone sample file.
[Obsolete("This method is deprecated. Use NewMethod instead.")]
public void OldMethod()
{
    Console.WriteLine("Old method called");
}

public void NewMethod()
{
    Console.WriteLine("New method called");
}

public class Problem235
{
    public static async Task Main()
    {
        NewMethod();

        await Task.CompletedTask;
    }
}