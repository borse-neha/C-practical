using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 231. Program to demonstrate event handling basics
// Generated as a standalone sample file.
public class Publisher
{
    public event Action<string> OnMessage;

    public void SendMessage(string message)
    {
        OnMessage?.Invoke(message);
    }
}

public class Subscriber
{
    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Received: {message}");
    }
}

public class Problem231
{
    public static async Task Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        publisher.OnMessage += subscriber.ReceiveMessage;
        publisher.SendMessage("Hello, World!");

        await Task.CompletedTask;
    }
}