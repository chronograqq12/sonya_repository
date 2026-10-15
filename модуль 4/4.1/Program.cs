using System;
namespace _4._1
{
    //любой класс-фигура обязаний реализовать методы, задаваемые интерфейсом
    interface IFigure
    {
        double GetArea();      //метод для вычисления площади
        double GetPerimeter(); //метод для вычисления периметра
    }
    //класс круг реализует интерфейс IFigure
    class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius; //сохр радиус при создании
        }
        public double GetArea() => Math.PI * radius * radius; //формула площади круга
        public double GetPerimeter() => 2 * Math.PI * radius;  //формула длины окружности (периметра)
    }
    //класс прямоугольник реализует интерфейс IFigure
    class Rectangle : IFigure
    {
        private double width, height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height; //сохр стороны
        }
        public double GetArea() => width * height;         //площадь прямоугольника
        public double GetPerimeter() => 2 * (width + height); //периметр прямоугольника
    }
    //класс треугольник реализует интерфейс IFigure
    class Triangle : IFigure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c; //сохр стороны треугольника
        }
        public double GetPerimeter() => a + b + c; //периметр треугольника
        public double GetArea()
        {
            double p = GetPerimeter() / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //площадь по формуле Герона
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //исп полиморфизм через интерфейсную ссылку
            IFigure figure = new Circle(5);
            Console.WriteLine($"Круг: площадь = {figure.GetArea():F1}, периметр = {figure.GetPerimeter():F1}");
            //изм объект на прямоугольник, интерфейсный тип остается тем же
            figure = new Rectangle(4, 6);
            Console.WriteLine($"Прямоугольник: площадь = {figure.GetArea()}, периметр = {figure.GetPerimeter()}");
            //изм объект на треугольник, интерфейсный тип остается тем же
            figure = new Triangle(3, 4, 5);
            Console.WriteLine($"Треугольник: площадь = {figure.GetArea():F1}, периметр = {figure.GetPerimeter()}");
        }
    }
}