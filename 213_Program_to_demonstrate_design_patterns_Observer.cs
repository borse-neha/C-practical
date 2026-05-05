using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 213. Program to demonstrate design patterns (Observer)
// Generated as a standalone sample file.
public interface IObserver
{
    void Update(string message);
}

public class ConcreteObserver : IObserver
{
    public string Name { get; set; }

    public ConcreteObserver(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{Name} received: {message}");
    }
}

public class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

public class Problem213
{
    public static async Task Main()
    {
        Subject subject = new Subject();
        ConcreteObserver obs1 = new ConcreteObserver("Observer1");
        ConcreteObserver obs2 = new ConcreteObserver("Observer2");
        subject.Attach(obs1);
        subject.Attach(obs2);
        subject.Notify("Hello Observers!");

        await Task.CompletedTask;
    }
}