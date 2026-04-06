using System;

class Program
{
    static void Main()
    {
        // -------- 1D ARRAY --------
        Console.Write("Enter number of elements in 1D array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements of 1D array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("1D Array Elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        // Sorting
        Array.Sort(arr);
        Console.WriteLine("\nSorted 1D Array:");
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }

        // Searching
        Console.Write("\nEnter element to search: ");
        int key = Convert.ToInt32(Console.ReadLine());
        int pos = Array.IndexOf(arr, key);

        if (pos != -1)
            Console.WriteLine("Element found at position " + (pos + 1));
        else
            Console.WriteLine("Element not found");

        // -------- 2D ARRAY --------
        Console.Write("\nEnter number of rows: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[r, c];

        Console.WriteLine("Enter elements of 2D array:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("2D Array Elements:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
