using System;

namespace _4._4
{
    //интерфейс книги задает набор требований для работы с изданием
    interface IBook
    {
        bool IsAvailable(); //метод проверки доступности книги
        void IssueBook(); //метод для выдачи книги читателю
        void ShowInfo(); //метод для вывода информации о книге
    }
    //класс книги реализует интерфейс IBook
    class Book : IBook
    {
        private string title;
        private bool available;
        public Book(string title, bool available)
        {
            this.title = title;
            this.available = available; //сохр данные при создании
        }
        public bool IsAvailable() => available; //возвр статус наличия
        public void IssueBook()
        {
            if (available)
            {
                available = false; //меняем статус на "выдана"
                Console.WriteLine($"Книга \"{title}\" успешно выдана.");
            }
            else
            {
                Console.WriteLine($"Книга \"{title}\" сейчас отсутствует.");
            }
        }
        public void ShowInfo()
        {
            string status = available ? "доступна" : "выдана";
            Console.WriteLine($"Книга: \"{title}\", Статус: {status}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем книги через интерфейсные ссылки без циклов и массивов
            IBook book1 = new Book("C# для начинающих", true);
            book1.ShowInfo();

            IBook book2 = new Book("Алгоритмы и структуры данных", false);
            book2.ShowInfo();
        }
    }
}