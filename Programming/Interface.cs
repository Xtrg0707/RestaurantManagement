using System;

internal class Interface
{
    public static void MenuBoard()
    {
        Console.Clear();
        Console.WriteLine("\t\t|      [RESTAURANT MANAGEMENT SYSTEMS]     |");
        Console.WriteLine("\t\t|__________________________________________|");
        Console.WriteLine("\t\t|  [1] Add a new table                     |");
        Console.WriteLine("\t\t|  [2] Edit information in a table         |");
        Console.WriteLine("\t\t|  [3] Remove table by ID                  |");
        Console.WriteLine("\t\t|  [4] Extract bill                        |");
        Console.WriteLine("\t\t|  [5] Show all of table statistic         |");
        //Console.WriteLine("\t\t|  [6]           |");
        //Console.WriteLine("\t\t|  [7]           |");
        Console.WriteLine("\t\t|  [0] Exit the application                |");
        Console.WriteLine("\t\t|________________.*.<~>.*._________________|");
        Console.Write("\n\t\t[Your choice]");
        Console.Beep();
    }

    public static bool ConfirmSubmissionBox()
    {
        Console.Write("\n\tSubmit [Y]");
        Console.WriteLine("\t\tUnsubmit [Any key]");
        Console.Write("\n\tYour answer: ");
        if (char.Parse(Console.ReadLine()) == 'Y')
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public static void ShowSuccessMessage()
    {
        Console.WriteLine("\n\tSubmit successfully !");
        Console.ResetColor();
        Console.ReadKey();
    }

    public static void ShowUnsuccessMessage()
    {
        Console.WriteLine("\n\tYour change is not submited !");
        Console.ResetColor();
        Console.ReadKey();
    }

    public static void ShowRequestMessage()
    {
        Console.WriteLine("\n\tPress any key to return home screen");
    }
}
