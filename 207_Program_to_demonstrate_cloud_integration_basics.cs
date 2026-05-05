using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 207. Program to demonstrate cloud integration basics (mock Azure blob storage)
// Generated as a standalone sample file.
public class MockBlobStorage
{
    private Dictionary<string, string> storage = new Dictionary<string, string>();

    public void UploadBlob(string container, string blobName, string content)
    {
        string key = $"{container}/{blobName}";
        storage[key] = content;
        Console.WriteLine($"Uploaded blob {blobName} to container {container}");
    }

    public string DownloadBlob(string container, string blobName)
    {
        string key = $"{container}/{blobName}";
        return storage.ContainsKey(key) ? storage[key] : "Blob not found";
    }
}

public class Problem207
{
    public static async Task Main()
    {
        MockBlobStorage storage = new MockBlobStorage();
        storage.UploadBlob("mycontainer", "myblob.txt", "Hello from cloud!");
        string content = storage.DownloadBlob("mycontainer", "myblob.txt");
        Console.WriteLine($"Downloaded content: {content}");

        await Task.CompletedTask;
    }
}