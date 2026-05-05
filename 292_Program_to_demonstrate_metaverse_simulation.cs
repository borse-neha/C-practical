using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 292. Program to demonstrate metaverse simulation
// Generated as a standalone sample file.
public class MetaverseAvatar
{
    public string Name { get; set; }

    public void Interact(string action)
    {
        Console.WriteLine($"{Name} performs {action} in metaverse");
    }
}

public class Problem292
{
    public static async Task Main()
    {
        MetaverseAvatar avatar = new MetaverseAvatar { Name = "User1" };
        avatar.Interact("dance");
        avatar.Interact("chat");

        await Task.CompletedTask;
    }
}