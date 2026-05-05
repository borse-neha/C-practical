using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 285. Program to demonstrate natural language processing simulation
// Generated as a standalone sample file.
public class NLPAnalyzer
{
    public string AnalyzeSentiment(string text)
    {
        if (text.Contains("good") || text.Contains("great"))
            return "Positive";
        else if (text.Contains("bad") || text.Contains("terrible"))
            return "Negative";
        return "Neutral";
    }
}

public class Problem285
{
    public static async Task Main()
    {
        NLPAnalyzer nlp = new NLPAnalyzer();
        Console.WriteLine(nlp.AnalyzeSentiment("This is a great day"));
        Console.WriteLine(nlp.AnalyzeSentiment("This is terrible"));

        await Task.CompletedTask;
    }
}