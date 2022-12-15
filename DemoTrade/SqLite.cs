using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace DemoTrade
{
    class SqLite
    {
        SQLiteConnection connection =  new SQLiteConnection(@"Data Source=userslite.db;Version=3; FailIfMissing=False");
        SQLiteCommand command = new SQLiteCommand();
        string insertSql = "INSERT INTO user (name, surname, login, password) VALUES";

        public void Connection()
        {
            connection.Open();
        }

        public void AddDatabase()
        {
            command.CommandText = insertSql + "(\"Иванов\",\"Иван\", \"trst\",\"tgrt\")";
        }
    }
}
