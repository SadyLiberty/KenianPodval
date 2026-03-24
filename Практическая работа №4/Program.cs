using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Console.WriteLine("Добро пожаловать в игру с животными!");
            Console.WriteLine();

            cat.Voice();

            Console.Write("Сколько лет кошке? ");
            int age = Convert.ToInt32(Console.ReadLine());

            cat.ShowAge(age);
            cat.CountEat();
            cat.CountHealth();

            Console.WriteLine();

            Dog dog = new Dog();
            dog.Voice();

            Parrot parrot = new Parrot();
            parrot.Voice();
        }
    }

    interface IAnimal
    {
        void Voice();
    }

    class Cat : IAnimal
    {
        public int health = 9;
        public int dryFood = 2;
        public int wetFood = 3;
        public int water = 1;

        public void Voice()
        {
            Console.WriteLine("Кошка говорит: мур мур ");
        }

        public void ShowAge(int age)
        {
            Console.WriteLine($"Кошке {age} лет");
        }

        public void CountHealth()
        {
            Console.WriteLine($"Жизней кошки: {health} / еще 9");
        }

        public void CountEat()
        {
            Console.WriteLine($"Сухой корм: {dryFood}");
            Console.WriteLine($"Влажный корм: {wetFood}");
            Console.WriteLine($"Воды в день: {water} нигалитров");
        }
    }

    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Собака говорит: ав ав ");
        }
    }

    class Parrot : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Попугай говорит: кар кар");
        }
    }
}

