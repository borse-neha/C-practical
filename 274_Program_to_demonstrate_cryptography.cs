using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// 274. Program to demonstrate cryptography
// Generated as a standalone sample file.
public class CryptoService
{
    public (string publicKey, string privateKey) GenerateKeys()
    {
        using (RSA rsa = RSA.Create())
        {
            string publicKey = rsa.ToXmlString(false);
            string privateKey = rsa.ToXmlString(true);
            return (publicKey, privateKey);
        }
    }

    public string Encrypt(string plainText, string publicKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.FromXmlString(publicKey);
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
            return Convert.ToBase64String(encrypted);
        }
    }

    public string Decrypt(string cipherText, string privateKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.FromXmlString(privateKey);
            byte[] data = Convert.FromBase64String(cipherText);
            byte[] decrypted = rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}

public class Problem274
{
    public static async Task Main()
    {
        CryptoService crypto = new CryptoService();
        var keys = crypto.GenerateKeys();
        string original = "Secret message";
        string encrypted = crypto.Encrypt(original, keys.publicKey);
        string decrypted = crypto.Decrypt(encrypted, keys.privateKey);
        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Decrypted: {decrypted}");

        await Task.CompletedTask;
    }
}