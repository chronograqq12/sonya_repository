namespace _1._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите нижнюю границу A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнюю границу B: ");
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
            Console.WriteLine("Массив: " + string.Join(", ", arr));
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= arr[minIndex])
                {
                    minIndex = i;
                }
                if (arr[i] >= arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int startIndex = minIndex < maxIndex ? minIndex : maxIndex;
            int endIndex = minIndex > maxIndex ? minIndex : maxIndex;

            Console.Write("Элементы между минимальным и максимальным (включая их): ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}