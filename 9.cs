using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";

        // Writing to file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            Console.Write("Enter text to write into file: ");
            string text = Console.ReadLine();
            writer.WriteLine(text);
        }

        Console.WriteLine("\nData written to file successfully.");

        // Reading from file
        Console.WriteLine("\nReading data from file:");
        using (StreamReader reader = new StreamReader(filePath))
        {
            string data;
            while ((data = reader.ReadLine()) != null)
            {
                Console.WriteLine(data);
            }
        }

        Console.ReadLine();
    }
}
