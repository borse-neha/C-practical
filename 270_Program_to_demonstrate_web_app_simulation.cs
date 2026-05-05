using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// 270. Program to demonstrate web app simulation
// Generated as a standalone sample file.
public class WebApp
{
    public void HandleRequest(string path)
    {
        if (path == "/")
            Console.WriteLine("Serving home page");
        else if (path == "/about")
            Console.WriteLine("Serving about page");
        else
            Console.WriteLine("404 Not Found");
    }
}

public class Problem270
{
    public static async Task Main()
    {
        WebApp app = new WebApp();
        app.HandleRequest("/");
        app.HandleRequest("/about");
        app.HandleRequest("/contact");

        await Task.CompletedTask;
    }
}