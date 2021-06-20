using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Diary_Management.Data_Access
{
    class ActivityDB
    {
        readonly private DBAccess dBAccess;

        public ActivityDB()
        {
            dBAccess = new DBAccess();
        }
    }
}
