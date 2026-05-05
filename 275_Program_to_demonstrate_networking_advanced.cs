using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

// 275. Program to demonstrate networking advanced
// Generated as a standalone sample file.
public class TCPServer
{
    public async Task StartServer()
    {
        TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 8080);
        listener.Start();
        Console.WriteLine("Server started on port 8080");
        TcpClient client = await listener.AcceptTcpClientAsync();
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        Console.WriteLine($"Received: {message}");
        listener.Stop();
    }
}

public class Problem275
{
    public static async Task Main()
    {
        TCPServer server = new TCPServer();
        await server.StartServer();

        await Task.CompletedTask;
    }
}