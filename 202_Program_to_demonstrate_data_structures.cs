using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 202. Program to demonstrate data structures (stack and queue)
// Generated as a standalone sample file.
public class Problem202
{
    public static async Task Main()
    {
        // Stack demonstration
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine("Stack popped: " + stack.Pop());
        Console.WriteLine("Stack top: " + stack.Peek());

        // Queue demonstration
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Queue dequeued: " + queue.Dequeue());
        Console.WriteLine("Queue front: " + queue.Peek());

        await Task.CompletedTask;
    }
}