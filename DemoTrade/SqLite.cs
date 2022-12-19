using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace DemoTrade
{
    class SqLite
    {
        SQLiteConnection connection;
        SQLiteCommand command;

        public SQLiteConnection Connection()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=usersql.db.;Version=3; FailIfMissing=False");
            connection.Open();

            return connection;
        }

        public void CloseConnection()
        {
            connection.Close(); 
        }

        public void AddDatabase(User user)
        {
            SQLiteConnection connection = Connection();
            SQLiteCommand command = new SQLiteCommand(connection)
            {
                CommandText = @"INSERT INTO user(name, surname, login, password) VALUES('" + user.Name + @"', '" + user.Surname + @"', '" + user.Login + @"', '" + user.Password + @"')"
            };
            command.ExecuteNonQuery();
        }


        public bool SearchData(string desired, string column)
        {
            SQLiteConnection connection = Connection();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = System.Data.CommandType.Text;
            
            command.CommandText = "SELECT * FROM user WHERE "+column+" LIKE '" + desired + "'";
            SQLiteDataReader reader = command.ExecuteReader();

             return reader.HasRows;
        }
 
    }
}
