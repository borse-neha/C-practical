using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 214. Program to demonstrate design patterns (Strategy)
// Generated as a standalone sample file.
public interface ISortStrategy
{
    void Sort(int[] array);
}

public class BubbleSort : ISortStrategy
{
    public void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

public class QuickSort : ISortStrategy
{
    public void Sort(int[] array)
    {
        // Simple quicksort implementation
        Array.Sort(array);
    }
}

public class Sorter
{
    private ISortStrategy strategy;

    public Sorter(ISortStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(ISortStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SortArray(int[] array)
    {
        strategy.Sort(array);
    }
}

public class Problem214
{
    public static async Task Main()
    {
        int[] array = { 3, 1, 4, 1, 5 };
        Sorter sorter = new Sorter(new BubbleSort());
        sorter.SortArray(array);
        Console.WriteLine("Sorted with BubbleSort: " + string.Join(", ", array));

        array = new int[] { 3, 1, 4, 1, 5 };
        sorter.SetStrategy(new QuickSort());
        sorter.SortArray(array);
        Console.WriteLine("Sorted with QuickSort: " + string.Join(", ", array));

        await Task.CompletedTask;
    }
}