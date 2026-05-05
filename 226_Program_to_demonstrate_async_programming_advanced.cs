using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 226. Program to demonstrate async programming advanced (Task.WhenAll)
// Generated as a standalone sample file.
public class Problem226
{
    public static async Task Main()
    {
        Task<int> task1 = Task.Run(() => { Task.Delay(1000).Wait(); return 1; });
        Task<int> task2 = Task.Run(() => { Task.Delay(1000).Wait(); return 2; });
        Task<int> task3 = Task.Run(() => { Task.Delay(1000).Wait(); return 3; });

        int[] results = await Task.WhenAll(task1, task2, task3);
        Console.WriteLine("Results: " + string.Join(", ", results));

        await Task.CompletedTask;
    }
}