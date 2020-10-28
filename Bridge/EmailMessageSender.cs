using System;

namespace Bridge
{
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine("\n'" + Message + "'\n\t~This Message has been sent using Email~");
        }
    }
}
