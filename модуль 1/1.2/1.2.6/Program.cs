namespace _1._2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            int[] indices = new int[10];
            Random random = new Random();
            Console.Write("Массив: ");
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-10, 10) + random.NextDouble();
                indices[i] = i;
                Console.Write(Math.Round(array[i], 1) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9 - i; j++)
                {
                    if (array[indices[j]] > array[indices[j + 1]])
                    {
                        int temp = indices[j];
                        indices[j] = indices[j + 1];
                        indices[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Массив индексов по возрастанию: " + string.Join(", ", indices));
        }
    }
}