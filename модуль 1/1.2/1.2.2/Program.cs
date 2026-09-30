namespace _1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }
            Console.WriteLine("Исходный массив: " + string.Join(", ", arr));
            Console.Write("Введите число для замены максимума: ");
            int replacement = int.Parse(Console.ReadLine());
            int maxVal = arr[0];
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxVal)
                {
                    maxVal = arr[i];
                    maxIndex = i;
                }
            }
            arr[maxIndex] = replacement;

            Console.WriteLine("Измененный массив: " + string.Join(", ", arr));
        }
    }
}