namespace _1._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1, 11);
            Console.Write("Угадайте число от 1 до 10: ");
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine(guess == secret ? "Число угадано" : $"Неверно. Было загадано: {secret}");
        }
    }
}