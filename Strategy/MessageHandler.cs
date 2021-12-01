using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler
    {
        internal static IMessenger Messenger = new EmailMessenger(); // Default messenger

        internal static void SendMessage(string message)
        {
            Messenger.SendMessage(message);
        }
    }
}