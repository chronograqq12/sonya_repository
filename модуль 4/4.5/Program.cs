using System;

namespace _4._5
{
    //интерфейс рисунка
    interface IDrawing
    {
        void DrawLine();      //метод для рисования линии
        void DrawCircle();    //метод для рисования круга
        void DrawRectangle(); //метод для рисования прямоугольника
    }
    //класс холста реализует интерфейс IDrawing
    class Canvas : IDrawing
    {
        public void DrawLine() => Console.WriteLine("Нарисована линия.");
        public void DrawCircle() => Console.WriteLine("Нарисован круг.");
        public void DrawRectangle() => Console.WriteLine("Нарисован прямоугольник.");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем холст через интерфейсную ссылку
            IDrawing canvas = new Canvas();

            //вызываем методы рисования фигур
            canvas.DrawLine();
            canvas.DrawCircle();
            canvas.DrawRectangle();
        }
    }
}
