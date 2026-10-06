using System;

namespace _2._4
{
    //интерфейс задает общий контракт для всех рисуемых объектов
    interface IDrawable
    {
        void Draw();
    }

    //класс круга реализует интерфейс IDrawable
    class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("рисуем круг.");
        }
    }
    //класс прямоугольника реализует интерфейс IDrawable
    class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("рисуем прямоугольник.");
        }
    }
    //класс треугольника реализует интерфейс IDrawable
    class Triangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("рисуем треугольник.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //созд массив интерфейсного типа для полиморфного хранения разных объектов
            IDrawable[] shapes = new IDrawable[3];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();
            shapes[2] = new Triangle();
            //в цикле вызываем метод Draw для каждого объекта в массиве
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();
            }
        }
    }
}