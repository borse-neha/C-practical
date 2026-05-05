using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 282. Program to demonstrate bioinformatics simulation
// Generated as a standalone sample file.
public class DNASequence
{
    public string Sequence { get; set; }

    public DNASequence(string seq)
    {
        Sequence = seq;
    }

    public string Complement()
    {
        return Sequence.Replace('A', 't').Replace('T', 'a').Replace('C', 'g').Replace('G', 'c').ToUpper();
    }
}

public class Problem282
{
    public static async Task Main()
    {
        DNASequence dna = new DNASequence("ATCG");
        Console.WriteLine($"Original: {dna.Sequence}");
        Console.WriteLine($"Complement: {dna.Complement()}");

        await Task.CompletedTask;
    }
}