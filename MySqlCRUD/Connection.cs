using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySqlCRUD
{
    class Connection
    {
        public MySqlConnection dbConnect()
        {
            //String connect = "server=localhost;Username=root;Password=,Database=ccrud";
            string connect = "Server=localhost; Port=3306; Database=ccrud; Uid=root; Pwd=;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connect);
            return conn;
        }
    }
}
