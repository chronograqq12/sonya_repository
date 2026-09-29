namespace _1._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вид перевода (1 из °C в °F, 2 из °F в °C): ");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Градусы Цельсия: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"В Фаренгейтах: {c * 1.8 + 32}");
            }
            else
            {
                Console.Write("Градусы Фаренгейта: ");
                double f = double.Parse(Console.ReadLine());
                Console.WriteLine($"В Цельсиях: {(f - 32) / 1.8}");
            }
        }
    }
}