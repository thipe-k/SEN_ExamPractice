using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Diary_Management.Presentation
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void personsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            PersonMaintenanceForm personMaintenanceForm = new PersonMaintenanceForm();
            personMaintenanceForm.ShowDialog();
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            TeamMaintenanceForm teamMaintenanceForm = new TeamMaintenanceForm();
            teamMaintenanceForm.ShowDialog();
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void schedulesButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.ShowInTaskbar = false;

            //this.ShowInTaskbar = true;
            //this.Show();
        }
    }
}
