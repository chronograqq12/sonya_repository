using System;
namespace sr1
{
    class Employee
    {
        //поля для хранения данных о сотруднике
        private string name;
        private int age;
        private string position;
        private double salary;
        //конструктор по умолчанию
        public Employee()
        {
            name = "не указано";
            age = 0;
            position = "не указана";
            salary = 0.0;
        }
        //конструктор с параметрами для инициализации объекта
        public Employee(string name, int age, string position, double salary)
        {
            this.name = name;
            this.age = age;
            this.position = position;
            this.salary = salary;
        }
        //методы для установки и получения значений полей
        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }
        public void SetAge(int age) { this.age = age; }
        public int GetAge() { return age; }
        public void SetPosition(string position) { this.position = position; }
        public string GetPosition() { return position; }
        public void SetSalary(double salary) { this.salary = salary; }
        public double GetSalary() { return salary; }

        // метод для расчета годового дохода (месячная зарплата умножается на 12 месяцев)
        public double CalculateAnnualIncome()
        {
            return salary * 12;
        }
        //метод для вывода информации о сотруднике
        public void PrintInfo()
        {
            Console.WriteLine("сотрудник: " + name + ", возраст: " + age + ", должность: " + position + ", зарплата: " + salary + ", годовой доход: " + CalculateAnnualIncome());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //созд объект сотрудника через конструктор с параметрами
            Employee emp1 = new Employee("соня", 30, "разработчик", 2500.0);
            //созд второго сотрудника и заполнение через сеттеры
            Employee emp2 = new Employee();
            emp2.SetName("лера");
            emp2.SetAge(18);
            emp2.SetPosition("тестировщик");
            emp2.SetSalary(1800.0);
            //вывод инфы и тест функциональности
            emp1.PrintInfo();
            emp2.PrintInfo();
        }
    }
}
