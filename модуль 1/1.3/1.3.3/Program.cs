using System;

namespace _1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы (N): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = random.Next(-50, 51);
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                {
                    int sum1 = 0, sum2 = 0;
                    for (int k = 0; k < n; k++) { sum1 += matrix[j, k]; sum2 += matrix[j + 1, k]; }
                    if (sum1 > sum2)
                        for (int k = 0; k < n; k++) { int t = matrix[j, k]; matrix[j, k] = matrix[j + 1, k]; matrix[j + 1, k] = t; }
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}