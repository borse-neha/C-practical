using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 244. Program to demonstrate microservices simulation
// Generated as a standalone sample file.
public class ServiceA
{
    public string GetMessage()
    {
        return "Message from Service A";
    }
}

public class ServiceB
{
    public string ProcessMessage(string message)
    {
        return $"Processed: {message}";
    }
}

public class Problem244
{
    public static async Task Main()
    {
        ServiceA serviceA = new ServiceA();
        ServiceB serviceB = new ServiceB();
        string msg = serviceA.GetMessage();
        string processed = serviceB.ProcessMessage(msg);
        Console.WriteLine(processed);

        await Task.CompletedTask;
    }
}