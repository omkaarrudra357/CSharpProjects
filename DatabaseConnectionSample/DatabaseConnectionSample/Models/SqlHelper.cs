using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DatabaseConnectionSample.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server = 200411LTP2873\SQLEXPRESS; database=TestDB; integrated security=true; Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;

        }
    }
}
