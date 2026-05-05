using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 281. Program to demonstrate quantum computing simulation
// Generated as a standalone sample file.
public class Qubit
{
    public double Measure()
    {
        Random rand = new Random();
        return rand.NextDouble() > 0.5 ? 1 : 0;
    }
}

public class QuantumSimulator
{
    public void Simulate()
    {
        Qubit qubit = new Qubit();
        Console.WriteLine($"Qubit measurement: {qubit.Measure()}");
    }
}

public class Problem281
{
    public static async Task Main()
    {
        QuantumSimulator sim = new QuantumSimulator();
        sim.Simulate();

        await Task.CompletedTask;
    }
}