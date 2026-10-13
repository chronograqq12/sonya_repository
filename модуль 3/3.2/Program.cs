using System;
namespace _3._2
{
    //делегат для обработки уведомлений, принимающий текст сообщения
    delegate void NotificationHandler(string message);
    class Notifier
    {
        //события для разных типов уведомлений
        public event NotificationHandler OnMessageReceived;
        public event NotificationHandler OnCallReceived;
        public event NotificationHandler OnEmailReceived;
        //методы для симуляции прихода уведомлений
        public void SimulateMessage(string text)
        {
            if (OnMessageReceived != null) OnMessageReceived(text);
        }
        public void SimulateCall(string caller)
        {
            if (OnCallReceived != null) OnCallReceived(caller);
        }
        public void SimulateEmail(string subject)
        {
            if (OnEmailReceived != null) OnEmailReceived(subject);
        }
    }
    class NotificationHandlers
    {
        public void HandleMessage(string text)
        {
            Console.WriteLine("новое смс: \"" + text + "\"");
        }
        public void HandleCall(string caller)
        {
            Console.WriteLine("входящий звонок от: " + caller);
        }
        public void HandleEmail(string subject)
        {
            Console.WriteLine("новое письмо на почту. тема: \"" + subject + "\"");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            NotificationHandlers handlers = new NotificationHandlers();
            //подписываем методы на соответствующие события
            notifier.OnMessageReceived += handlers.HandleMessage;
            notifier.OnCallReceived += handlers.HandleCall;
            notifier.OnEmailReceived += handlers.HandleEmail;
            //имитируем события в системе
            notifier.SimulateMessage("привет, как дела?");
            notifier.SimulateCall("мама");
            notifier.SimulateEmail("отчет по практике");
        }
    }
}