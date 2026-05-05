using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 211. Program to demonstrate design patterns (Singleton)
// Generated as a standalone sample file.
public class Singleton
{
    private static Singleton instance;
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void ShowMessage()
    {
        Console.WriteLine("Singleton instance message");
    }
}

public class Problem211
{
    public static async Task Main()
    {
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;
        Console.WriteLine("Same instance: " + (s1 == s2));
        s1.ShowMessage();

        await Task.CompletedTask;
    }
}