using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Homework_DocunentManagement_
{

    internal class DataBase
    {
        NpgsqlConnection npgsqlconnecting = new NpgsqlConnection("Server = localhost;port = 5432;Database= DocumentManagement; User Id=postgres; Password = 123");

        public void openconnection()
        {
            if (npgsqlconnecting.State == System.Data.ConnectionState.Closed)
            {
                npgsqlconnecting.Open();
            }
        }

        public void closedConnection()
        {
            if (npgsqlconnecting.State == System.Data.ConnectionState.Open)
            {
                npgsqlconnecting.Close();
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return npgsqlconnecting;
        }
    }
}
