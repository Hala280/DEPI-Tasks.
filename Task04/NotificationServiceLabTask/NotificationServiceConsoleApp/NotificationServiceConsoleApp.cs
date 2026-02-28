using System;


namespace NotificationService
{
	public interface INotificationService
	{
		public void SendNotification(string recipient, string message);
	}


	public class EmailNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			Console.WriteLine($"Email sent to {recipient}: {message}");
		}
	}

	public class SmsNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			Console.WriteLine($"SMS sent to {recipient}: {message}");
		}
	}

	public class PushNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			Console.WriteLine($"Push notification sent to {recipient}: {message}");
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			string recipient = "Hala";
			string message = "Hello, this is a notification!";
			INotificationService emailService = new EmailNotificationService();
			INotificationService smsService = new SmsNotificationService();
			INotificationService pushService = new PushNotificationService();
			emailService.SendNotification(recipient, message);
			smsService.SendNotification(recipient, message);
			pushService.SendNotification(recipient, message);
		}
	}
}
