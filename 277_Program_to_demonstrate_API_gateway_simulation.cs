using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 277. Program to demonstrate API gateway simulation
// Generated as a standalone sample file.
public class APIGateway
{
    private Dictionary<string, string> routes = new Dictionary<string, string>
    {
        { "/api/users", "UserService" },
        { "/api/orders", "OrderService" }
    };

    public string RouteRequest(string path)
    {
        return routes.ContainsKey(path) ? $"Routing to {routes[path]}" : "Route not found";
    }
}

public class Problem277
{
    public static async Task Main()
    {
        APIGateway gateway = new APIGateway();
        Console.WriteLine(gateway.RouteRequest("/api/users"));
        Console.WriteLine(gateway.RouteRequest("/api/products"));

        await Task.CompletedTask;
    }
}