using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 219. Program to demonstrate configuration management basics
// Generated as a standalone sample file.
public class ConfigManager
{
    private Dictionary<string, string> config = new Dictionary<string, string>();

    public ConfigManager()
    {
        config["AppName"] = "MyApp";
        config["Version"] = "1.0";
        config["Debug"] = "true";
    }

    public string GetSetting(string key)
    {
        return config.ContainsKey(key) ? config[key] : "Not found";
    }

    public void SetSetting(string key, string value)
    {
        config[key] = value;
    }
}

public class Problem219
{
    public static async Task Main()
    {
        ConfigManager config = new ConfigManager();
        Console.WriteLine($"App Name: {config.GetSetting("AppName")}");
        Console.WriteLine($"Version: {config.GetSetting("Version")}");
        Console.WriteLine($"Debug: {config.GetSetting("Debug")}");

        config.SetSetting("Debug", "false");
        Console.WriteLine($"Updated Debug: {config.GetSetting("Debug")}");

        await Task.CompletedTask;
    }
}