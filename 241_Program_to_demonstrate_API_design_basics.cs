using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 241. Program to demonstrate API design basics
// Generated as a standalone sample file.
public interface IApiService
{
    string GetData();
    void PostData(string data);
}

public class ApiService : IApiService
{
    public string GetData()
    {
        return "Data from API";
    }

    public void PostData(string data)
    {
        Console.WriteLine($"Posted: {data}");
    }
}

public class Problem241
{
    public static async Task Main()
    {
        IApiService api = new ApiService();
        Console.WriteLine(api.GetData());
        api.PostData("New data");

        await Task.CompletedTask;
    }
}