using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            int minPrice = 20;
            /*
             0---5---10-------20-------100---------------->бесконечность
            */

            Console.Write("Введите цену товара:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Вариант 1 - && логическое И");

            //покупаем все товары от 20 до 100 рублей
            if (minPrice <= price && price <= money)
            {
                Console.WriteLine("Покупаем");
            }
            else
            {
                Console.WriteLine("Не покупаем");
            }

            Console.WriteLine();
            Console.WriteLine("Вариант 2 - || логическое ИЛИ");
            //товары меньше 20 рублей  или товары больше 100 рублей нам не подходят
            if (price < minPrice || price > money)
            {
                Console.WriteLine("Не покупаем");
            }
            else
            {
                Console.WriteLine("Покупаем");
            }

            Console.WriteLine();
            Console.WriteLine("Вариант 3 - ! НЕ и || логическое ИЛИ");
            //все товары кроме товаров меньше 20 рублей  или товаров больше 100 рублей покупаем
            if (!(price < minPrice || price > money))
            {
                Console.WriteLine("Покупаем");
            }
            else
            {
                Console.WriteLine("Не покупаем");
            }
        }
    }
}
