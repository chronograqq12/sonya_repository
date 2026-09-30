namespace _1._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива K: ");
            int k = int.Parse(Console.ReadLine());
            char[] letters = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я' };
            string vowels = "аеёиоуыэюя";
            char[] array = new char[k];
            Random random = new Random();
            Console.Write("Исходный массив: ");
            for (int i = 0; i < k; i++)
            {
                array[i] = letters[random.Next(letters.Length)];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                if (!vowels.Contains(array[i])) count++;
            }
            char[] consonants = new char[count];
            int index = 0;
            for (int i = 0; i < k; i++)
            {
                if (!vowels.Contains(array[i]))
                {
                    consonants[index++] = array[i];
                }
            }
            Console.WriteLine("Только согласные: " + string.Join(" ", consonants));
        }
    }
}