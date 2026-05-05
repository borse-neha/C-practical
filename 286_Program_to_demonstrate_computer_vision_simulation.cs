using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 286. Program to demonstrate computer vision simulation
// Generated as a standalone sample file.
public class ComputerVision
{
    public string RecognizeObject(string imageData)
    {
        // Mock recognition
        if (imageData.Contains("cat"))
            return "Cat detected";
        return "Object not recognized";
    }
}

public class Problem286
{
    public static async Task Main()
    {
        ComputerVision cv = new ComputerVision();
        Console.WriteLine(cv.RecognizeObject("image of a cat"));
        Console.WriteLine(cv.RecognizeObject("image of a dog"));

        await Task.CompletedTask;
    }
}