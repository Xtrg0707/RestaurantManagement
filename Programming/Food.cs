using System;

internal class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Food(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public Food()
    {
    }


    public static void PrintInformation()
    {
        Console.WriteLine($"", Id, Name, Price);
    }

    public static double CalculateMoney()
    {
        double result = 1;
        return result;
    }
}
