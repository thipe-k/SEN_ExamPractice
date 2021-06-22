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
    public partial class TeamSelectForm : Form
    {
        IList<Team> teams;
        public Team SelectedTeam { get; set; }
        public TeamSelectForm()
        {
            InitializeComponent();
        }

        public TeamSelectForm(IList<Team> teams, Team selectedTeam)
        {
            InitializeComponent();
            this.teams = teams;
            this.SelectedTeam = selectedTeam;
        }

        private void TeamSelectForm_Load(object sender, EventArgs e)
        {
            teamListBox.DataSource = teams;
            teamListBox.DisplayMember = "DisplayName";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectedTeam = teamListBox.SelectedItem as Team;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
