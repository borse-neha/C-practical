using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 218. Program to demonstrate logging basics
// Generated as a standalone sample file.
public class Logger
{
    public void LogInfo(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now}: {message}");
    }
}

public class Problem218
{
    public static async Task Main()
    {
        Logger logger = new Logger();
        logger.LogInfo("Application started");
        try
        {
            int result = 10 / 0;
        }
        catch (Exception ex)
        {
            logger.LogError($"Exception occurred: {ex.Message}");
        }
        logger.LogInfo("Application ended");

        await Task.CompletedTask;
    }
}