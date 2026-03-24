using System;

internal class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.Voice();
        cat.CountEat();
        cat.CountHealth();

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
        Console.WriteLine("Мяу");
    }

    public void CountHealth()
    {
        Console.WriteLine($"Жизней кошки: {health} / 9");
    }

    public void CountEat()
    {
        Console.WriteLine($"Норма по сухому корму: {dryFood}");
        Console.WriteLine($"Норма по влажному корму: {wetFood}");
        Console.WriteLine($"Воды в день: {water} л");
    }
}

class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав");
    }
}

class Parrot : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Чик-чирик");
    }
}






