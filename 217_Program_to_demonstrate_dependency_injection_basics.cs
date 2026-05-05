using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 217. Program to demonstrate dependency injection basics
// Generated as a standalone sample file.
public interface IMessageService
{
    void SendMessage(string message);
}

public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class SMSService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

public class Notification
{
    private IMessageService messageService;

    public Notification(IMessageService service)
    {
        messageService = service;
    }

    public void Notify(string message)
    {
        messageService.SendMessage(message);
    }
}

public class Problem217
{
    public static async Task Main()
    {
        IMessageService emailService = new EmailService();
        Notification notification = new Notification(emailService);
        notification.Notify("Hello via Email");

        IMessageService smsService = new SMSService();
        notification = new Notification(smsService);
        notification.Notify("Hello via SMS");

        await Task.CompletedTask;
    }
}