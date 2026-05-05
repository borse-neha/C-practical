using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 257. Program to demonstrate fault tolerance
// Generated as a standalone sample file.
public class FaultTolerantService
{
    public string CallService(int retryCount = 0)
    {
        if (retryCount < 3)
        {
            // Mock failure
            if (new Random().Next(2) == 0)
            {
                Console.WriteLine("Service failed, retrying...");
                return CallService(retryCount + 1);
            }
        }
        return "Service response";
    }
}

public class Problem257
{
    public static async Task Main()
    {
        FaultTolerantService service = new FaultTolerantService();
        string response = service.CallService();
        Console.WriteLine(response);

        await Task.CompletedTask;
    }
}