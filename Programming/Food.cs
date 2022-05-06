using System;

internal class Food
{
    public static int Id { get; set; }
    public static string Name { get; set; }
    public static double Price { get; set; }

    public Food(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public Food()
    {
    }

    public void EditTableInfor(int id, string name, double price)
    {
        // Not yet
        Console.ReadKey();
    }

    public void PrintInformation()
    {
        Console.WriteLine($"", Id, Name, Price);
    }

    public static double CalculateMoney()
    {
        double result = 1;
        return result;
    }
}
