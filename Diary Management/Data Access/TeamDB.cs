using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Diary_Management.Data_Access
{
    public class TeamDB
    {
        readonly private DBAccess dBAccess;
        public TeamDB()
        {
            dBAccess = new DBAccess();
        }
        public DataTable GetTeams(params string[] data)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection con = dBAccess.DBConnection)
                {
                    string query = string.Format("SELECT * [dbo].[Team] WHERE [Identifier]= '{0}' OR [Name] = '{1}' OR [Schedule] = '{2}' ", data[0], data[1], data[2] );
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
        public DataTable GetTeamMembers( string teamID)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection con = dBAccess.DBConnection)
                {
                    string query = string.Format(" SELECT* FROM[Person] P INNER JOIN[Job] J ON J.Person = P.Identifier WHERE J.Team = '{0}' ", teamID);
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
