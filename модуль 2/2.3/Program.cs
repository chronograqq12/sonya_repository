using System;

namespace _2._3
{
    //класс для хранения данных об авторе книги
    class Author
    {
        public string Name;
        public int BirthYear;

        //конструктор для инициализации автора
        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
    }
    //класс для описания книги, содержащий внутри себя объект автора (композиция)
    class Book
    {
        public string Title;
        public int Year;
        public Author Author; //книга ссыл на объект автора
        //конструктор книги
        public Book(string title, int year, Author author)
        {
            Title = title;
            Year = year;
            Author = author;
        }
        //метод для вывода информации о книге и ее авторе
        public void PrintInfo()
        {
            Console.WriteLine("книга: " + Title + " (" + Year + "), автор: " + Author.Name + " (род. " + Author.BirthYear + ")");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //созд объект автора
            Author author1 = new Author("лев толстой", 1828);
            //созд объект книги, передавая автора внутрь через конструктор
            Book book1 = new Book("война и мир", 1869, author1);
            book1.PrintInfo();
        }
    }
}























