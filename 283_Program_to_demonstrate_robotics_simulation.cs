using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 283. Program to demonstrate robotics simulation
// Generated as a standalone sample file.
public class Robot
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public void Move(string direction, int steps)
    {
        switch (direction)
        {
            case "north": Y += steps; break;
            case "south": Y -= steps; break;
            case "east": X += steps; break;
            case "west": X -= steps; break;
        }
        Console.WriteLine($"Moved {direction} by {steps}. Position: ({X}, {Y})");
    }
}

public class Problem283
{
    public static async Task Main()
    {
        Robot robot = new Robot();
        robot.Move("north", 5);
        robot.Move("east", 3);

        await Task.CompletedTask;
    }
}