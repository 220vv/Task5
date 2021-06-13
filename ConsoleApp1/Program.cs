using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool - логічний тип

            bool no = false;
            bool yes = true;

            Console.WriteLine($"5 < 6 : {5 < 6}"); //true
            Console.WriteLine($"7 < 5 {7 < 5}"); //false
            Console.WriteLine($"5 <= 5 {5 <= 5}"); //true
            Console.WriteLine($"7 == 7 {7 == 7}"); //true
            Console.WriteLine($"7 > 5 {7 > 5}"); //true
            Console.WriteLine($"7 >= 5 {7 >= 5}"); //true
            Console.WriteLine($"7 >= 7 {7 >= 7}"); //true
            // = означає покласти значення в змінну 

            //if else
            int d = 0;
            if (d >= 0)
            {
                Console.WriteLine(" >= 0");
            }
            else if (d < -10)
            {
                Console.WriteLine("< -10");
            }
            else //-1...-10
            {
                Console.WriteLine("-1...-10");
            }

            //swith

            switch (d)
            {
                case 0:
                    Console.WriteLine("ноль");
                    break;
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                default:
                    Console.WriteLine("другое число");
                    break;
            }
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            switch (name)
            {
                case "Степан":
                    name = "Стёпа";
                    break;
                case "Александр":
                    name = "Саша";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Привет {name}!");
        }
    }
}