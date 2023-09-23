using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayThree
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
    }
    public interface Ipayments
    {
        void MakePayment(float amount);
    }
    internal class Whatsapp : IMessageService, Ipayments
    {
        public void DeleteMessage() 
        {
            Console.WriteLine("msg deleted"); 
        }
        public void ReceiveMessage()
        {
            Console.WriteLine($"Method not implemented");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void MakePayment(float amount)
        {
            Console.WriteLine($"Paid amount {amount}");
        }

    }
    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new Whatsapp();
            messageService.SendMessage("hello");
            messageService.ReceiveMessage();
        }

        

    }
}
