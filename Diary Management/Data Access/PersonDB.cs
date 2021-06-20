using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Diary_Management.Data_Access
{
    public class PersonDB
    {
        readonly private DBAccess dBAccess;

        public PersonDB()
        {
            dBAccess = new DBAccess();
        }

        public DataTable GetPerson(params string[] data)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection con = dBAccess.DBConnection)
                {
                    string query = string.Format("SELECT * FROM [dbo].[Person] WHERE [DateOfBirth] = '{0}' OR [FirstName] = '{1}' OR [Identifier] = '{2}' OR [IdentityNumber] = {3} OR [OtherNames] = '{4}' OR [Schedule] = '{5}' OR [Sex] = {6} OR [Suffix] = '{7}' OR [Surname] = '{8}' OR [Title] = {9} ", data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]);
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dataTable;
        }
    }
}
