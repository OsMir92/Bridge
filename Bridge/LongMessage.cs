namespace Bridge
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }
        public override void SendMessage(string Message)
        {
            messageSender.SendMessage(Message);
        }
    }
}
