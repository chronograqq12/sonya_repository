using System;
namespace _3._5
{
    //делегат для алгоритма сортировки массива целых чисел
    delegate void SortDelegate(int[] array);
    internal class Program
    {
        //алгоритм 1: сортировка пузырьком
        static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        //алгоритм 2: сортировка выбором
        static void SelectionSort(int[] array)
        {
            int minIndex, temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            //создаем и заполняем массив случайными числами (например, 8 штук от 1 до 99)
            Random rand = new Random();
            int[] numbers = new int[8];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 100);
            }
            Console.WriteLine("сгенерированный массив: " + string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine("выберите метод сортировки:");
            Console.WriteLine("1 - сортировка пузырьком");
            Console.WriteLine("2 - сортировка выбором");
            Console.Write("введите номер (1 или 2): ");
            string choice = Console.ReadLine();
            //объявляем делегат, который будем передавать
            SortDelegate sortingMethod = null;
            if (choice == "1")
            {
                sortingMethod = BubbleSort;
            }
            else if (choice == "2")
            {
                sortingMethod = SelectionSort;
            }
            else
            {
                Console.WriteLine("неверный выбор, программа завершена.");
                return;
            }
            //выполняем сортировку через выбранный делегат
            sortingMethod(numbers);
            Console.WriteLine("\nрезультат сортировки: " + string.Join(", ", numbers));
        }
    }
}