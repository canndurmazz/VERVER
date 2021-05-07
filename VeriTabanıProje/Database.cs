using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VeriTabanıProje
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=CANPC\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

    }
}
