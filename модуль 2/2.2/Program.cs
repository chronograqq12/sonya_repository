using System;

namespace _2._2
{
    //базовый абстрактный класс для геометрических фигур
    abstract class Shape
    {
        //абстрактный метод для вычисления площади
        public abstract double Area();
        //периметр
        public abstract double Perimeter();
    }
    //класс круга, наследующий абстрактный класс Shape
    class Circle : Shape
    {
        private double radius;
        //конструктор для радиуса
        public Circle(double r)
        {
            radius = r;
        }
        //переопределение метода расчета площади круга
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        //переопределение метода расчета периметра
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
    //прямоугольник
    class Rectangle : Shape
    {
        private double width;
        private double height;
        //конструктор для сторон
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        //переопределение метода расчета площади прямоугольника
        public override double Area()
        {
            return width * height;
        }
        //периметр
        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //объекты фигур через ссылку базового типа
            Shape circle = new Circle(3);
            Shape rect = new Rectangle(6, 7);
            Console.WriteLine("круг: площадь = " + circle.Area() + ", периметр = " + circle.Perimeter());
            Console.WriteLine("прямоугольник: площадь = " + rect.Area() + ", периметр = " + rect.Perimeter());
        }
    }
}