using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 203. Program to demonstrate algorithms (bubble sort)
// Generated as a standalone sample file.
public class Problem203
{
    public static async Task Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array: " + string.Join(", ", arr));

        // Bubble sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array: " + string.Join(", ", arr));

        await Task.CompletedTask;
    }
}