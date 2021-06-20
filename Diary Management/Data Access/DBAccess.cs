using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Diary_Management.Data_Access
{
     class DBAccess
    {
       readonly private SqlConnectionStringBuilder con;
        public SqlConnection DBConnection { get { return new SqlConnection(con.ConnectionString); }  }

        public DBAccess()
        {
            con = new SqlConnectionStringBuilder();
            con.InitialCatalog = "Diary";
            con.DataSource = "(Local)";
            con.IntegratedSecurity = true;
        }
    }
}
