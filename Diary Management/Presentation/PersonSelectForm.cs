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
    public partial class PersonSelectForm : Form
    {
        public Person PersonObject { get; set; }
        IList<Person> persons;
        public PersonSelectForm()
        {
            InitializeComponent();
        }
        public PersonSelectForm( IList<Person> persons, Person selectedPerson)
        {
            PersonObject = selectedPerson;
            this.persons = persons;
            InitializeComponent();
        }

        private void PersonSelectForm_Load(object sender, EventArgs e)
        {
            personListBox.DataSource = persons;
            personListBox.DisplayMember = "Info";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            PersonObject = personListBox.SelectedItem as Person;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void personListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                PersonObject = personListBox.SelectedItem as Person;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
