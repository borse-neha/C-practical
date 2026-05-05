using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 293. Program to demonstrate Web3 simulation
// Generated as a standalone sample file.
public class Web3Wallet
{
    public string Address { get; } = "0x123456789";

    public void SendTransaction(string to, double amount)
    {
        Console.WriteLine($"Sending {amount} to {to} from {Address}");
    }
}

public class Problem293
{
    public static async Task Main()
    {
        Web3Wallet wallet = new Web3Wallet();
        wallet.SendTransaction("0xabcdef", 1.5);

        await Task.CompletedTask;
    }
}