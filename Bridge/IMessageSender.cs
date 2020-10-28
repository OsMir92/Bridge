using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface IMessageSender
    {
        void SendMessage(string Message);
    }
}
