using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Console.WriteLine("вапвапвапвап");
            Console.WriteLine();

            cat.Voice();

            Console.Write("Сколько лет кошке? ");
            int age = Convert.ToInt32(Console.ReadLine());
            cat.ShowAge(age);

            Console.Write("Покормить кошку? (да/нет): ");
            string eat = Console.ReadLine();

            if (eat.ToLower() == "да")
            {
                cat.Feed();
            }
            else
            {
                Console.WriteLine("Кошка жрать хочкт ");
                cat.health--;
            }

            Console.Write("Дать кошке воду? (да/нет): ");
            string drink = Console.ReadLine();

            if (drink.ToLower() == "да")
            {
                Console.WriteLine("Кошка попила воды ");
            }
            else
            {
                Console.WriteLine("Кошка хочет пить ");
                cat.health--;
            }

            cat.CountHealth();

            Console.WriteLine("Игра конец");
        }
    }

    interface IAnimal
    {
        void Voice();
    }

    class Cat : IAnimal
    {
        public int health = 9;

        public void Voice()
        {
            Console.WriteLine("Кошка: Мяу  мур ");
        }

        public void ShowAge(int age)
        {
            Console.WriteLine($"Кошке {age} нига лет");
        }

        public void Feed()
        {
            Console.WriteLine("Кошка нига  покушала ");
        }

        public void CountHealth()
        {
            Console.WriteLine($"хп кошки: {health}-9");
        }
    }
}
