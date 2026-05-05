using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

// 223. Program to demonstrate networking basics (TCP client simulation)
// Generated as a standalone sample file.
public class Problem223
{
    public static async Task Main()
    {
        try
        {
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync("httpbin.org", 80);
                NetworkStream stream = client.GetStream();
                string request = "GET /get HTTP/1.1\r\nHost: httpbin.org\r\nConnection: close\r\n\r\n";
                byte[] data = Encoding.ASCII.GetBytes(request);
                await stream.WriteAsync(data, 0, data.Length);
                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Response received.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        await Task.CompletedTask;
    }
}