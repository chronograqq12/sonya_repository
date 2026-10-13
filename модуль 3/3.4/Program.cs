using System;
using System.Collections.Generic;
namespace _3._4
{
    //делегат для проверки условия фильтрации
    delegate bool FilterPredicate(string text);
    internal class Program
    {
        //метод фильтрации принимает список и делегат-условие
        static List<string> FilterList(List<string> items, FilterPredicate condition)
        {
            List<string> filtered = new List<string>();
            foreach (var item in items)
            {
                if (condition(item))
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }
        static void Main(string[] args)
        {
            List<string> items = new List<string>
            {
                "ошибка: база недоступна",
                "успех: вход выполнен",
                "ошибка: таймаут сети",
                "инфо: запуск программы"
            };
            Console.WriteLine("все элементы:");
            foreach (var s in items) Console.WriteLine(s);
            Console.WriteLine();
            //фильтруем только ошибки, передавая условие через делегат
            List<string> errors = FilterList(items, delegate (string s) {
                return s.Contains("ошибка");
            });
            Console.WriteLine("только ошибки:");
            foreach (var err in errors) Console.WriteLine(err);
        }
    }
}