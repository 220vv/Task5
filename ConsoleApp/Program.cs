using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Привет мир!");

            //один символ дорівнює 2 байта
            //char c = 'a';

            //string str = "приклад";
            //розмір рядка в байтах
            //Console.WriteLine($"розмiр в байтах { str.Length * 2}");

            //індекс букв починається з 0
            //приклад виведення букви по її індексу
            //Console.WriteLine(str[0]);

            //з'єднання рядків - конкатинація
            //string t1 = "привeт";
            //string t2 = ", мир!";
            //string t12 = t1 + t2 + "!!";
            //Console.WriteLine(t12);

            //переведення рядків в числа
            //string userInput = Console.ReadLine();

            //може викликати помилку
            //int input = int.Parse(userInput);

            //int input;
            //int.TryParse("12345"+"65463", out input);
            //Console.WriteLine(input*2);

            //переведення числа в рядок
            //int age = 20;
            //string q = "Вам " + age + " рокiв";
            //string q2 = age.ToString();

            //подстрока 20
            //Console.WriteLine(q.Substring(4,2));

            //Console.WriteLine(q.IndexOf("20"));

            //Console.WriteLine(q.ToLower());

            //Console.WriteLine("Як вас звати?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Привiт, {name}!");

            //qqq = string.Format("Вам {0} лет {1}", age, "!");
            //АБО
            //string q = $"Вам {age} лет";

            //string.IsNullOrEmpty("11");
            //string.IsNullOrEmpty("");
            
            //виникає помилка, тому що в змінній нічого немає
            string ddd = null;
            Console.WriteLine(ddd.Length);
        }
    }
}