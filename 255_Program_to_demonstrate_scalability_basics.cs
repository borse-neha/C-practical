using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 255. Program to demonstrate scalability basics
// Generated as a standalone sample file.
public class ScalableService
{
    public void HandleRequest(int requestId)
    {
        Console.WriteLine($"Handling request {requestId} on thread {Task.CurrentId}");
    }
}

public class Problem255
{
    public static async Task Main()
    {
        ScalableService service = new ScalableService();
        List<Task> tasks = new List<Task>();
        for (int i = 1; i <= 10; i++)
        {
            int id = i;
            tasks.Add(Task.Run(() => service.HandleRequest(id)));
        }
        await Task.WhenAll(tasks);

        await Task.CompletedTask;
    }
}