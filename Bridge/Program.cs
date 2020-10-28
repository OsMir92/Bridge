using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        protected static void Menu()
        {
            Console.Write("\n [1] Long message \n [2] Short message" +
                    "\n\n Select the Message Type: ");

            string MessageType = Console.ReadLine();

            if (MessageType == "1")
            {
                Console.WriteLine("\nPlease enter the message that you want to send");
                string Message = Console.ReadLine();
                AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
                longMessage.SendMessage(Message);
            }
            else if(MessageType == "2")
            {
                Console.WriteLine("\nPlease enter a message under 30 characters that you want to send");
                string Message = Console.ReadLine();
                AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
                shortMessage.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("\nPlease choose a valid option.[Press ENTER]");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }   
}