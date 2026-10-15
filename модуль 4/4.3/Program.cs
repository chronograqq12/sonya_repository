using System;

namespace _4._3
{
    //интерфейс определяет набор требований для работы со студентом
    interface IStudent
    {
        double GetAverageGrade(); //метод для расчета среднего балла
        string GetCourseInfo(); //метод для получения информации о курсе
        void ShowInfo(); //метод для вывода полной информации
    }
    //класс студента реализует интерфейс IStudent
    class Student : IStudent
    {
        private string fullName;
        private int course;
        private double avgGrade;

        public Student(string fullName, int course, double avgGrade)
        {
            this.fullName = fullName;
            this.course = course;
            this.avgGrade = avgGrade; //сохр данные при создании
        }
        public double GetAverageGrade() => avgGrade; //возвр средний балл
        public string GetCourseInfo() => $"{course}-й курс"; //форм строку курса

        public void ShowInfo()
        {
            Console.WriteLine($"Студент: {fullName}, Курс: {GetCourseInfo()}, Средний балл: {GetAverageGrade():F1}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем студентов через интерфейсные ссылки без циклов и массивов
            IStudent student1 = new Student("Лера Стальмакова", 2, 8.4);
            student1.ShowInfo();

            IStudent student2 = new Student("Соня Сидько", 3, 9.1);
            student2.ShowInfo();

            IStudent student3 = new Student("Милана Кухальская", 1, 7.6);
            student3.ShowInfo();
        }
    }
}