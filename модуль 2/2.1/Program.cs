using System;

namespace _2._1
{
    class Person
    {
        //поля для хранения данных
        private string name;
        private int age;
        private string address;
        //метод для установки имени
        public void SetName(string newName)
        {
            name = newName;
        }
        //метод для получения имени
        public string GetName()
        {
            return name;
        }
        //метод для установки возраста
        public void SetAge(int newAge)
        {
            age = newAge;
        }
        //метод для получения возраста
        public int GetAge()
        {
            return age;
        }
        //метод для установки адреса
        public void SetAddress(string newAddress)
        {
            address = newAddress;
        }
        //метод для получения адреса
        public string GetAddress()
        {
            return address;
        }
        //метод для вывода информации о человеке
        public void PrintInfo()
        {
            Console.WriteLine("имя: " + name + ", возраст: " + age + ", адрес: " + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1ый человек
            Person person1 = new Person();
            person1.SetName("лера");
            person1.SetAge(18);
            person1.SetAddress("маслаки");

            //2ой человек
            Person person2 = new Person();
            person2.SetName("соня");
            person2.SetAge(17);
            person2.SetAddress("витебск");
            person1.PrintInfo();
            person2.PrintInfo();
        }
    }
}