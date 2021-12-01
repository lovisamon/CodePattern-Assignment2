using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy
    {
        internal static void Run()
        {
            Console.WriteLine("Strategy");
            var message = "This is the message";

            MessageHandler.Messenger = new EmailMessenger();
            MessageHandler.SendMessage(message);

            MessageHandler.Messenger = new SMSMessenger();
            MessageHandler.SendMessage(message);

            MessageHandler.Messenger = new FacebookMessenger();
            MessageHandler.SendMessage(message);

            Console.WriteLine();
        }
    }
}