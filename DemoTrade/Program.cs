using System;
using HashLib;
using System.Data.SQLite;
using DemoTrade.ConsoleWork;

namespace DemoTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.SetWindowSize(80,26);
            //User user = new User();

            MenuMain main = new MenuMain();
            main.OutputMenuMain();

            //SqLite sqLite = new SqLite();
            //sqLite.Connection();

            //SQLiteConnection connection = new SQLiteConnection(@"Data Source=usersql.db.;Version=3; FailIfMissing=False");
            //connection.Open();
            //SQLiteCommand command = new SQLiteCommand(connection);

            //ConsoleWorkBase consoleWork = new ConsoleWorkBase();
            //ConsoleTime consoleTime = new ConsoleTime();
            //consoleTime.threadStartRealTime();
        }
    }
}
