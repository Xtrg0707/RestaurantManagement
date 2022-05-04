using System;

internal class UserAction
{
    private Table table = new Table();

    private static int InputIdTable(int index)
    {
        int tableID;
        Console.Clear();
        Console.Write("\tENTER TABLE ID [" + (index + 1) + "] \n\t>_");
        tableID = int.Parse(Console.ReadLine());
        return (tableID);
    }

    private static string InputFoodName(int index)
    {
        string foodName;
        Console.Write("\n\tENTER THE FOOD NAME [" + (index + 1) + "] \n\t>_");
        foodName = Console.ReadLine();
        return (foodName);
    }
    private static double InputPrice(int index)
    {
        double foodPrice;
        Console.Write("\n\tENTER THE PRICE [" + (index + 1) + "] \n\t");
        foodPrice = double.Parse(Console.ReadLine());
        return (foodPrice);
    }


    public static Table CreateNewTableInfor(int index)
    {
        Table table = new Table(InputIdTable(index), InputFoodName(index), InputPrice(index));
        return table;
    }

    public void AddANewTable()
    {
        Console.Write("\n\t\tEnter Number ID: ");
        int i = int.Parse(Console.ReadLine());
        table = CreateNewTableInfor(i);
    }

    public void EditTableInfor()
    {

        Console.ReadKey();
    }

    public void InputRemovingTableID()
    {
        int id;
        Console.Write("\n\tENTER TABLE ID\n\t>_");
        id = int.Parse(Console.ReadLine());
        Table.RemoveTableByID(id);
        Console.ReadKey();
    }

    public int ExtractBill()
    {
        Console.Clear();
        return 1;
    }

    public void DisplayAllTable()
    {
        Console.Clear();
        Table.PrintAllTables();
        Console.WriteLine("\n\tPress any key to return home screen");
        Console.ReadKey();
    }

}