using System;

abstract class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract decimal CalculateSalary();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}

class Manager : Employee
{
    private const decimal FixedSalary = 5000;

    public override decimal CalculateSalary()
    {
        return FixedSalary;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Должность: Менеджер, Зарплата: {CalculateSalary()}");
    }
}

class Developer : Employee
{
    public int HoursWorked { get; set; }
    private const decimal HourlyRate = 30;

    public override decimal CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Должность: Разработчик, Зарплата: {CalculateSalary()}");
    }
}

class Program
{
    static void Main()
    {
        Employee manager = new Manager { Name = "Иван Петров", Age = 40 };
        Employee developer = new Developer { Name = "Анна Сидорова", Age = 30, HoursWorked = 160 };

        manager.DisplayInfo();
        Console.WriteLine();
        developer.DisplayInfo();
    }
}