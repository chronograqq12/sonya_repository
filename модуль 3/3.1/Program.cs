using System;
namespace _3._1
{
    //делегат для метода расчета площади, возвращающего double и не принимающего параметров
    delegate double AreaCalculator();
    //базовый класс фигура
    class Shape
    {
        public virtual double CalculateArea() { return 0.0; }
    }

    //класс круга
    class Circle : Shape
    {
        private double radius;
        public Circle(double radius) { this.radius = radius; }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    //класс прямоугольника
    class Rectangle : Shape
    {
        private double width, height;
        public Rectangle(double width, double height) { this.width = width; this.height = height; }
        public override double CalculateArea()
        {
            return width * height;
        }
    }
    //класс треугольника
    class Triangle : Shape
    {
        private double baseSide, height;
        public Triangle(double baseSide, double height) { this.baseSide = baseSide; this.height = height; }
        public override double CalculateArea()
        {
            return 0.5 * baseSide * height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rect = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 8);
            //объявление переменной делегата
            AreaCalculator calc;
            //динамически привязываем метод круга и вызываем через делегат
            calc = circle.CalculateArea;
            Console.WriteLine("площадь круга: " + calc());
            //переназначаем делегат на прямоугольник
            calc = rect.CalculateArea;
            Console.WriteLine("площадь прямоугольника: " + calc());
            //переназначаем делегат на треугольник
            calc = triangle.CalculateArea;
            Console.WriteLine("площадь треугольника: " + calc());
        }
    }
}