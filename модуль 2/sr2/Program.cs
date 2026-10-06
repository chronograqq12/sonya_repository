using System;

namespace sr2
{
    class SampleClass
    {
        //две переменные класса
        private int firstValue;
        private string secondValue;
        //конструктор, инициализирующий члены класса по умолчанию
        public SampleClass()
        {
            firstValue = 10;
            secondValue = "по умолчанию";
        }
        //конструктор с входными параметрами
        public SampleClass(int val1, string val2)
        {
            firstValue = val1;
            secondValue = val2;
        }
        //метод для вывода значений переменных
        public void PrintValues()
        {
            Console.WriteLine("значение 1: " + firstValue + ", значение 2: " + secondValue);
        }
        //деструктор, выводящий сообщение об удалении объекта из памяти
        ~SampleClass()
        {
            Console.WriteLine("объект класса SampleClass удален сборщиком мусора.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //созд объект с использованием конструктора с параметрами
            SampleClass obj1 = new SampleClass(100, "тест");
            obj1.PrintValues();
            //созд объект с использованием конструктора по умолчанию
            SampleClass obj2 = new SampleClass();
            obj2.PrintValues();
        }
    }
}