using System;
using System.Linq;
namespace _1._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            bool isPalindrome = s.SequenceEqual(s.Reverse());
            Console.WriteLine(isPalindrome ? "Палиндром" : "Не палиндром");
        }
    }
}