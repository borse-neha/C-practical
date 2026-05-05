using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 269. Program to demonstrate desktop app simulation
// Generated as a standalone sample file.
public class DesktopApp
{
    public void ShowMenu()
    {
        Console.WriteLine("Menu: 1. Open 2. Save 3. Exit");
    }

    public void ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1: Console.WriteLine("Opening file..."); break;
            case 2: Console.WriteLine("Saving file..."); break;
            case 3: Console.WriteLine("Exiting..."); break;
        }
    }
}

public class Problem269
{
    public static async Task Main()
    {
        DesktopApp app = new DesktopApp();
        app.ShowMenu();
        app.ProcessChoice(1);
        app.ProcessChoice(3);

        await Task.CompletedTask;
    }
}