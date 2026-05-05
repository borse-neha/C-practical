using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// 229. Program to demonstrate security basics (password hashing)
// Generated as a standalone sample file.
public class Problem229
{
    public static async Task Main()
    {
        string password = "mypassword";
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);
            string hashed = BitConverter.ToString(hash).Replace("-", "").ToLower();
            Console.WriteLine($"Hashed password: {hashed}");
        }

        await Task.CompletedTask;
    }
}