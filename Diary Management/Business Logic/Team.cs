using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Diary_Management.Data_Access;

namespace Diary_Management.Business_Logic
{
    public class Team : IDiaryOwner, IComparable
    {
        private string identifier;
        private string teamName;
        private string schedule;
        public Diary Diary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Identifier { get => identifier; set => identifier = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public string DisplayName { get => $"{identifier} : {teamName}"; }
        public IList<Team> GetTeams { get; set; }

        public int CompareTo(object obj)
        {
            return (obj as Team).teamName.CompareTo(this.teamName);
        }
        public void Initialize(DataRow data)
        {
            identifier = data["Identifier"].ToString();
            teamName = data["Name"].ToString();
            schedule = data["Schedule"].ToString();
        }
        public Team() { }
        public Team(DataRow teamData) { Initialize(teamData); }

        public bool GetData()
        {
            GetTeams = new List<Team>();
            GetTeams.Clear();
            TeamDB teamDB = new TeamDB();
            DataTable data = teamDB.GetTeams(identifier, teamName, schedule);
            if (data.Rows.Count < 1)
            {
                return false;
            }
            else
            {
                if (data.Rows.Count > 1)
                {
                    foreach (DataRow teamData in data.Rows)
                    {
                        GetTeams.Add(new Team(teamData));
                    }
                }
                else 
                {
                    Initialize(data.Rows[0]);
                }
                return true;
            }
        }

        public IList<Person> GetTeamMembers()
        {
            IList<Person> teamMembers = new List<Person>();
            TeamDB teamDB = new TeamDB();
            foreach (DataRow data in teamDB.GetTeamMembers(identifier).Rows )
            {
                teamMembers.Add(new Person(data, true));
            }

            return teamMembers;
        }
    }
}
