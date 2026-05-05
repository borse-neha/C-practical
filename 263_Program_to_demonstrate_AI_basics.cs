using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 263. Program to demonstrate AI basics (chatbot simulation)
// Generated as a standalone sample file.
public class Chatbot
{
    public string Respond(string input)
    {
        if (input.Contains("hello"))
            return "Hello! How can I help?";
        return "I'm sorry, I don't understand.";
    }
}

public class Problem263
{
    public static async Task Main()
    {
        Chatbot bot = new Chatbot();
        Console.WriteLine(bot.Respond("hello"));
        Console.WriteLine(bot.Respond("what is AI?"));

        await Task.CompletedTask;
    }
}