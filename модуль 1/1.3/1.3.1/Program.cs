namespace _1._3._1
{
    internal class Program
    {
        static int Nod(int a, int b)
        {
            int ostatok;
            while (b!=0)
            {
                ostatok=a%b;
                a=b;
                b=ostatok;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите числитель: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            int b = int.Parse(Console.ReadLine());
            int d=Nod(a, b);
            a=a/d;
            b = b / d;
            Console.WriteLine("Сокращенная дробь: " + a + "/" + b);
        }
    }
}