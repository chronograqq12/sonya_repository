using System;
using System.Collections.Generic; //для использования List<T>

namespace sr3
{
    //класс автора
    class Author
{
    public string Name;
    public string Surname;
    public int BirthYear;
    public Author(string name, string surname, int birthYear)
    {
        Name = name;
        Surname = surname;
        BirthYear = birthYear;
    }
}
//класс книги (содержит автора через композицию)
class Book
{
    public string Title;
    public Author Author; //поле типа "автор" для связи между классами
    public int Year;
    public Book(string title, Author author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void PrintInfo()
    {
        Console.WriteLine("книга: \"" + Title + "\" (" + Year + "), автор: " + Author.Name + " " + Author.Surname);
    }
}
//класс библиотеки, содержащий список книг
class Library
{
    private List<Book> books = new List<Book>();
    //метод для добавления книги в список
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("книга \"" + book.Title + "\" добавлена в библиотеку.");
    }
    //метод для удаления книги из списка
    public void RemoveBook(Book book)
    {
        books.Remove(book);
        Console.WriteLine("книга \"" + book.Title + "\" удалена из библиотеки.");
    }
    //поиск книг по автору
    public void FindByAuthor(string surname)
    {
        Console.WriteLine("результаты поиска книг автора с фамилией \"" + surname + "\":");
        foreach (var book in books)
        {
            if (book.Author.Surname.ToLower() == surname.ToLower())
            {
                book.PrintInfo();
            }
        }
    }
    //поиск книг по году издания
    public void FindByYear(int year)
    {
        Console.WriteLine("результаты поиска книг за " + year + " год:");
        foreach (var book in books)
        {
            if (book.Year == year)
            {
                book.PrintInfo();
            }
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        //созд объекты авторов
        Author author1 = new Author("лев", "толстой", 1828);
        Author author2 = new Author("александр", "пушкин", 1799);
        //созд объекты книг, связывая их с авторами
        Book book1 = new Book("война и мир", author1, 1869);
        Book book2 = new Book("капитанская дочка", author2, 1836);
        //созд библиотеку и добавляем в нее книги
        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);
        Console.WriteLine();
        //тест поиска по автору и по году
        library.FindByAuthor("толстой");
        Console.WriteLine();
        library.FindByYear(1836);
    }
}
}