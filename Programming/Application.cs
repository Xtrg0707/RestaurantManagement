using System;


internal class Application
{
    public void Run()
    {
        int choice;
        UserAction userAction = new UserAction();
        do
        {
            Interface.MenuBoard();
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    userAction.AddANewTable();
                    break;

                case 2:
                    userAction.EditTableInfor();
                    break;

                case 3:
                    userAction.InputRemovingTableID();
                    break;

                case 4:
                    userAction.ExtractBill();
                    break;

                case 5:
                    userAction.DisplayAllTable();
                    break;
                default:
                    Console.WriteLine("\n\tYou have chosen invalid selection ! Please try again !");
                    Console.ReadKey();
                    break;
            }
        } while (choice != 0 || choice < 5);
        userAction = null;
        Console.Clear();

    }
}