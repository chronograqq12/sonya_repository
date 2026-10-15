using System;

namespace _4._2
{
    //интерфейс
    interface IProduct
    {
        double GetTotalPrice(); //метод для расчета общей стоимости партии
        int GetStockBalance();  //метод для получения остатка на складе
        void ShowInfo();        //метод для вывода информации о товаре
    }
    //класс конкретного товара реализует интерфейс IProduct
    class ProductItem : IProduct
    {
        private string name;
        private double price;
        private int quantity;

        public ProductItem(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity; //сохр переданные данные при создании
        }
        public double GetTotalPrice() => price * quantity; //общая стоимость = цена * количество
        public int GetStockBalance() => quantity;         //текущий остаток

        public void ShowInfo()
        {
            Console.WriteLine($"Товар: {name}, Цена: {price} руб., Остаток: {GetStockBalance()} шт., Общая сумма: {GetTotalPrice()} руб.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //массив товаров через интерфейсный тип
            IProduct[] warehouse = new IProduct[]
            {
                new ProductItem("Мышка", 75.0, 25),
                new ProductItem("Ноутбук", 2400.0, 5),
                new ProductItem("Телефон", 1200.0, 10)
            };

            //в цикле перебираются товары и выводится информация по каждому
            foreach (var item in warehouse)
            {
                item.ShowInfo();
            }
        }
    }
}