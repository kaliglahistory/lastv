﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Data;
using Microsoft.Data.SqlClient;

namespace _2
{
    class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed) {

                sqlConnection.Open();


            }
        }
        public void clocedConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {

                sqlConnection.Close();


            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}