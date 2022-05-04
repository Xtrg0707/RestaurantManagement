using System;
using System.Collections.Generic;
using System.Linq;


internal class Table
{
    public int Id;
    public string Name;
    public double Price;

    public List<Food> Foods = new List<Food>();

    public Table(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
        Foods = new List<Food>();
    }



    public void GetByID(int id)
    {
        var result = Tables.Where(table => table.Id == id).ToList();
        if (result.Count != 0)
        {
            result[0].PrintInformation();
            Interface.ShowRequestMessage();
        }
        else
        {
            Console.WriteLine("\n\tTHIS TABLE DOESN'T EXIST !");
        }
    }

    public void EditGradeByID(int id, string name, double price)
    {
        var result = Tables.Where(table => table.Id == id).ToList();
        if (result.Count != 0)
        {
            if (Interface.ConfirmSubmissionBox())
            {
                result[0].EditTable(id, name, price);
                Console.WriteLine("\n\tTHIS TABLE HAS BEEN SUBMITED !");
            }
            else
            {
                Console.WriteLine("\n\tTHIS TABBLE HAS BEEN DELETED !");
                return;
            }
        }
        else
        {
            Console.WriteLine("\n\tTHIS TABLE DOESN'T EXIST !");
        }
    }

    public static void RemoveTableByID(int id)
    {
        var result = Tables.Where(table => table.Id == id).ToList();
        bool confirm = Interface.ConfirmSubmissionBox();
        if (confirm)
        {
            Console.WriteLine("\n\tYOUR REQUEST IS SUBMITED !");
            Tables.Remove(result[0]);
        }
        else if (!confirm)
        {
            Console.WriteLine("\n\tYOUR REQUEST IS NOT SUBMITED !");
        }
        else
        {
            Console.WriteLine("\n\tYou cannot remove a table which does not exist!");
        }
    }

    public static void PrintAllTables()
    {
        foreach (var table in tables)
        {
            Food.PrintInformation();
        }
    }
}
