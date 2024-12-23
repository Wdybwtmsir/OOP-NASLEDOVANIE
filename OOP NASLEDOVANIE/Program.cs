using System;

public class Time
{
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public Time(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public string GetInfo()
    {
        return $"Количество часов: {Hours}, Количество минут: {Minutes}";
    }

    public int CalculateMinuti()
    {
        return (Hours * 60) + Minutes;
    }
}
public class Time2 : Time
{
    public int Dlitelnost { get; set; }

    public Time2(int hours, int minutes, int dlitelnost) : base(hours, minutes)
    {
        Dlitelnost = dlitelnost;
    }

    public int CalculateNumberOfOperations()
    {
        int totalMinutes = CalculateMinuti();
        if (Dlitelnost <= 0)
        {
            return 0;
        }
        return totalMinutes / Dlitelnost;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество часов: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Введите количество минут: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Введите длительность одной операции в минутах: ");
        int operationDuration = int.Parse(Console.ReadLine());

        Time  time = new Time(hours, minutes);
        Time2 time2 = new Time2(hours, minutes, operationDuration);

        Console.WriteLine("\nИнформация о базовом объекте:");
        Console.WriteLine(time.GetInfo());
        Console.WriteLine($"Общее количество минут: {time.CalculateMinuti()}");

        Console.WriteLine("\nИнформация о расширенном объекте:");
        Console.WriteLine(time2.GetInfo());
        Console.WriteLine($"Общее количество минут: {time2.CalculateMinuti()}");
        Console.WriteLine($"Количество операций: {time2.CalculateNumberOfOperations()}");
    }
}
