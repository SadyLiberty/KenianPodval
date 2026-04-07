using System;

class Car
{
    public string Brand;
    public string Model;
    public int Speed;
    private static int totalCarsCreated = 0;

    public Car()
    {
        Brand = "Unknown"; Model = "Unknown"; Speed = 0;
        totalCarsCreated++;
    }

    public Car(string brand, string model, int speed)
    {
        Brand = brand; Model = model; Speed = speed;
        totalCarsCreated++;
    }

    public static int GetTotalCars() => totalCarsCreated;
    public void PrintInfo() => Console.WriteLine($"Car: {Brand} {Model}, Speed: {Speed}");
}

class Student
{
    public string Name;
    public int Age;
    public string Group;
    public double AverageGrade;
    private static int totalStudents = 0;

    public Student() : this("Неизвестно") { }
    public Student(string name) : this(name, 18) { }
    public Student(string name, int age) : this(name, age, "Не определена", 0) { }

    public Student(string name, int age, string group, double grade)
    {
        Name = name; Age = age; Group = group; AverageGrade = grade;
        totalStudents++;
    }

    public static int GetTotalStudents() => totalStudents;
    public void PrintInfo() => Console.WriteLine($"Student: {Name}, Age: {Age}, Group: {Group}, Grade: {AverageGrade} niga ");
}

class CurrencyConverter
{
    public static double UsdToRubRate;
    public static double EuroToRubRate;

    public static void SetRates(double usd, double euro)
    {
        UsdToRubRate = usd; EuroToRubRate = euro;
    }

    public static double ConvertUsdToRub(double usd) => usd * UsdToRubRate;
    public static double ConvertEuroToRub(double euro) => euro * EuroToRubRate;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("номер 1 ");
        Car c1 = new Car();
        Car c2 = new Car("Toyota", "Camry", 180);
        Car c3 = new Car("BMW", "X5", 220);
        c1.PrintInfo(); c2.PrintInfo(); c3.PrintInfo();
        Console.WriteLine($"Всего автомобилей: {Car.GetTotalCars()}");

        Console.WriteLine("\nномер 2 ");
        Student s1 = new Student();
        Student s2 = new Student("Алексей");
        Student s3 = new Student("Мария", 20);
        Student s4 = new Student("Дмитрий", 22, "ИТ-301", 4.8);
        s1.PrintInfo(); s2.PrintInfo(); s3.PrintInfo(); s4.PrintInfo();
        Console.WriteLine($"Всего студентов: {Student.GetTotalStudents()}");

        Console.WriteLine("\nномер 3 ");
        CurrencyConverter.SetRates(90, 98);
        Console.Write("Введите сумму в долларах: ");
        double usd = double.Parse(Console.ReadLine());
        Console.Write("Введите сумму в евро: ");
        double euro = double.Parse(Console.ReadLine());
        Console.WriteLine($"{usd} USD = {CurrencyConverter.ConvertUsdToRub(usd)} руб.");
        Console.WriteLine($"{euro} EUR = {CurrencyConverter.ConvertEuroToRub(euro)} руб.");
    }
}
