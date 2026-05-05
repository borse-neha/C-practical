using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 239. Program to demonstrate message queues simulation
// Generated as a standalone sample file.
public class MessageQueue
{
    private Queue<string> queue = new Queue<string>();

    public void Enqueue(string message)
    {
        queue.Enqueue(message);
        Console.WriteLine($"Enqueued: {message}");
    }

    public string Dequeue()
    {
        if (queue.Count > 0)
        {
            string msg = queue.Dequeue();
            Console.WriteLine($"Dequeued: {msg}");
            return msg;
        }
        return null;
    }
}

public class Problem239
{
    public static async Task Main()
    {
        MessageQueue mq = new MessageQueue();
        mq.Enqueue("Message 1");
        mq.Enqueue("Message 2");
        mq.Dequeue();
        mq.Dequeue();

        await Task.CompletedTask;
    }
}