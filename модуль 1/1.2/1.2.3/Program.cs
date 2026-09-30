namespace _1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество простых чисел K: ");
            int k = int.Parse(Console.ReadLine());
            int count = 0;
            int num = 2;
            int[] arr = new int[k];
            while (count < k)
            {
                bool simple = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        simple = false;
                        break;
                    }
                }
                if (simple)
                {
                    arr[count] = num;
                    count++;
                }
                num++;
            }
            Console.WriteLine("Простые числа: " + string.Join(", ", arr));
        }
    }
}