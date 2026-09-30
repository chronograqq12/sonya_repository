namespace _1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];

            for (int i = 0; i<n; i++)
            {
                Console.Write($"Элемент {i}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            double maxAbs = Math.Abs(arr[0]);
            for (int i = 1; i<n; i++)
            {
                if (Math.Abs(arr[i])>maxAbs)
                {
                    maxAbs = Math.Abs(arr[i]);
                }
            }
            Console.Write("Нормированный массив: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = arr[i]/maxAbs;
                Console.Write(Math.Round(arr[i], 2) + " ");
            }
        }
    }
}