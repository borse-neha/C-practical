using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 267. Program to demonstrate game development basics
// Generated as a standalone sample file.
public class Game
{
    private int score = 0;

    public void Update()
    {
        score += 10;
        Console.WriteLine($"Score: {score}");
    }

    public bool IsGameOver()
    {
        return score > 100;
    }
}

public class Problem267
{
    public static async Task Main()
    {
        Game game = new Game();
        while (!game.IsGameOver())
        {
            game.Update();
            await Task.Delay(500);
        }
        Console.WriteLine("Game Over!");

        await Task.CompletedTask;
    }
}