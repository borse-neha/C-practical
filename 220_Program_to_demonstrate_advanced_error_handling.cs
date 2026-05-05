using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 220. Program to demonstrate advanced error handling
// Generated as a standalone sample file.
public class Problem220
{
    public static async Task Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }

        await Task.CompletedTask;
    }
}