using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PA.db
{
    public class ConnectionDB
    {
        public static NpgsqlConnection Connection()
        {
            string stringConnection = "Server=localhost;" +
                                      "Port=5432;" +
                                      "User ID=postgres;" +
                                      "Password=031298;" +
                                      "Database=db_pa;";

            NpgsqlConnection connection = new NpgsqlConnection(stringConnection);
            connection.Open();
            return connection;
        }

        public static void CRUD(NpgsqlCommand command)
        {
            NpgsqlConnection con = Connection();
            command.Connection = con;
            command.ExecuteNonQuery();
            con.Close();
        }

        public static NpgsqlDataReader Select(NpgsqlCommand command)
        {
            NpgsqlConnection con = Connection();
            command.Connection = con;
            NpgsqlDataReader dr = command.ExecuteReader();
            return dr;
        }
    }
}
