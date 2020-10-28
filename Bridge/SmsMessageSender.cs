using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine("\n'" + Message + "'\n\t~This Message has been sent using SMS~");
        }
    }
}
