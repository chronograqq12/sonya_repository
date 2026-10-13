using System;
using System.Collections.Generic;
namespace _3._3
{
    //делегат для обработки процесса выполнения задачи
    delegate void WorkDelegate(string details);
    internal class Program
    {
        //метод-обработчик для отправки уведомления
        static void NotifyUser(string info)
        {
            Console.WriteLine("отправлено уведомление по задаче: " + info);
        }
        //метод-обработчик для записи в системный журнал
        static void WriteLog(string info)
        {
            Console.WriteLine("запись в журнал событий: " + info);
        }
        static void Main(string[] args)
        {
            //список задач, где каждая задача хранит текст и назначенный ей делегат
            var taskList = new List<(string Description, WorkDelegate Processor)>
            {
                  ("проверка кода на ошибки", NotifyUser),
                ("резервное копирование бд", WriteLog),
                ("отправка отчета преподавателю", NotifyUser)
            };
            Console.WriteLine("начало выполнения списка задач:\n");
            //цикл для перебора и запуска каждой задачи
            foreach (var item in taskList)
            {
                Console.WriteLine("текущая задача: " + item.Description);
                item.Processor(item.Description); //вызов делегата
                Console.WriteLine();
            }
        }
    }
}