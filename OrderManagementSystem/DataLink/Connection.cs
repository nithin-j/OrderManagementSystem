using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace OrderManagementSystem.DataLink
{
    public static class Connection
    {
        public static SqlConnection SqlConnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["OMSDBConnection"].ConnectionString;
            sqlconn.Open();
            return sqlconn;
        }

    }
}
