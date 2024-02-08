using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OutlookDemo
{
    class Class_conn
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source="+Properties.Settings.Default.server+";Initial Catalog=EMP;Integrated Security=True");

       
    }
}
