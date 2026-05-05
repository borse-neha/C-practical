using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 287. Program to demonstrate speech recognition simulation
// Generated as a standalone sample file.
public class SpeechRecognizer
{
    public string Transcribe(string audioData)
    {
        // Mock transcription
        if (audioData.Contains("hello"))
            return "Hello";
        return "Unrecognized speech";
    }
}

public class Problem287
{
    public static async Task Main()
    {
        SpeechRecognizer sr = new SpeechRecognizer();
        Console.WriteLine(sr.Transcribe("audio hello world"));
        Console.WriteLine(sr.Transcribe("audio unknown"));

        await Task.CompletedTask;
    }
}