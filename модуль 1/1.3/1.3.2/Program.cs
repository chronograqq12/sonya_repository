using System;
namespace _1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            int x = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[0];
            int sum = 0;
            while (sum < x)
            {
                int val = random.Next(1, 10);
                if (sum + val > x)
                {
                    continue;
                }
                sum = sum + val;
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = val;
            }
            Console.WriteLine("Итоговая сумма: " + sum);
            Console.WriteLine("Количество элементов: " + array.Length);
            Console.WriteLine("Элементы массива: " + string.Join(", ", array));
        }
    }
}