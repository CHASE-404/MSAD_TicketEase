using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease
{
    public static class ConnectionManager
    {
        private static SQLiteConnection connection;

        public static SQLiteConnection Connection
        {
            get { return connection; }
        }

        public static SQLiteConnection GetSqlConnection()
        {
            connection = new SQLiteConnection();
            connection.ConnectionString = @"Data Source= C:\Users\kirby\Downloads\Ticket Ease_final kirk\MSAD_PROJECT.db";
            connection.Open();
            return connection;
        }

        public static void TurnOffSqlConnection()
        {
            connection.Close();
        }
    }
}
