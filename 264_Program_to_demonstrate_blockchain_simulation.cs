using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// 264. Program to demonstrate blockchain simulation
// Generated as a standalone sample file.
public class Block
{
    public int Index { get; set; }
    public string PreviousHash { get; set; }
    public string Data { get; set; }
    public string Hash { get; set; }

    public Block(int index, string previousHash, string data)
    {
        Index = index;
        PreviousHash = previousHash;
        Data = data;
        Hash = CalculateHash();
    }

    private string CalculateHash()
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            string input = Index + PreviousHash + Data;
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }
}

public class Blockchain
{
    private List<Block> chain = new List<Block>();

    public Blockchain()
    {
        chain.Add(new Block(0, "0", "Genesis Block"));
    }

    public void AddBlock(string data)
    {
        Block lastBlock = chain.Last();
        chain.Add(new Block(lastBlock.Index + 1, lastBlock.Hash, data));
    }

    public void PrintChain()
    {
        foreach (var block in chain)
        {
            Console.WriteLine($"Block {block.Index}: {block.Hash}");
        }
    }
}

public class Problem264
{
    public static async Task Main()
    {
        Blockchain bc = new Blockchain();
        bc.AddBlock("Transaction 1");
        bc.AddBlock("Transaction 2");
        bc.PrintChain();

        await Task.CompletedTask;
    }
}