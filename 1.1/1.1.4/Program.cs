namespace _1._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Минск", "Витебск", "Брест", "Гродно", "Гомель" };

            Console.WriteLine("Массив: Минск, Витебск, Брест, Гродно, Гомель");
            Console.Write("Введите название города: ");
            int i = Array.IndexOf(cities, Console.ReadLine());
            Console.WriteLine(i >= 0 ? $"Индекс: {i}" : "Нет в списке");
        }
    }
}