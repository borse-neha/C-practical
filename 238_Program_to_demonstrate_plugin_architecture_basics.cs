using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 238. Program to demonstrate plugin architecture basics
// Generated as a standalone sample file.
public interface IPlugin
{
    void Execute();
}

public class PluginA : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("Plugin A executed");
    }
}

public class PluginB : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("Plugin B executed");
    }
}

public class PluginManager
{
    private List<IPlugin> plugins = new List<IPlugin>();

    public void LoadPlugin(IPlugin plugin)
    {
        plugins.Add(plugin);
    }

    public void RunAll()
    {
        foreach (var plugin in plugins)
        {
            plugin.Execute();
        }
    }
}

public class Problem238
{
    public static async Task Main()
    {
        PluginManager manager = new PluginManager();
        manager.LoadPlugin(new PluginA());
        manager.LoadPlugin(new PluginB());
        manager.RunAll();

        await Task.CompletedTask;
    }
}