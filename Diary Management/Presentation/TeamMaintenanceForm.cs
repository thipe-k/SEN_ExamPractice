using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diary_Management.Business_Logic;

namespace Diary_Management.Presentation
{

    public partial class TeamMaintenanceForm : Form
    {
         private Team team;
        public TeamMaintenanceForm()
        {
            team = new Team();
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (team.GetData())
            {
                FillForm();
                MemberGridFill(team.GetTeamMembers());
            }
            else
            {
                this.Text = $"Team:";
                MessageBox.Show("Provided details has no match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillForm()
        {
            teamIdField.Text = team.Identifier;
            teamNameField.Text = team.TeamName;
            workingHoursField.SelectedItem = "";
            this.Text = $"Team: {team.TeamName}";
        }

        private void TeamMaintenanceForm_Load(object sender, EventArgs e)
        {

        }
        private void MemberGridFill(IList<Person> members)
        {
            memberGrid.DataSource = null;
            memberGrid.Columns.Clear();
            memberGrid.Rows.Clear();
            DataGridViewTextBoxColumn memberName = new DataGridViewTextBoxColumn();
            memberName.HeaderText = "Member";
            memberName.DataPropertyName = "DisplayName";
            DataGridViewTextBoxColumn memberRole = new DataGridViewTextBoxColumn();
            memberName.HeaderText = "Role";
            memberName.DataPropertyName = "Role";
            memberGrid.Columns.Add(memberName);
            memberGrid.Columns.Add(memberRole);
            memberGrid.DataSource = members;

        }
    }
}
