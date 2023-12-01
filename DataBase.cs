using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class DataBase
    {
        SqlConnection SqlCon = new SqlConnection(@"Server=Drako;database=Factory;Integrated Security=True");

        public void openConnection()
        {
            if(SqlCon.State == System.Data.ConnectionState.Closed)
            {
                SqlCon.Open();
            }
        }

        public void closeConnection() 
        {
            if (SqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlCon.Close();
            }
        }

        public SqlConnection GetConnection() { return SqlCon; }
        /*
        public Functions()
        {
            String ConStr = @"Data Source=Drako;Initial Catalog=Factory;Integrated Security=True"
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand;
        }
        public int SetData(string Query)
        {
            int Cnt;
            if (Con.State == System)
        }
        */
    }
}
