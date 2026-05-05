using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// 230. Program to demonstrate internationalization basics
// Generated as a standalone sample file.
public class Problem230
{
    public static async Task Main()
    {
        CultureInfo culture = new CultureInfo("fr-FR");
        Thread.CurrentThread.CurrentCulture = culture;
        DateTime now = DateTime.Now;
        Console.WriteLine($"Date in French: {now.ToString("D", culture)}");
        Console.WriteLine($"Currency: {1234.56.ToString("C", culture)}");

        await Task.CompletedTask;
    }
}