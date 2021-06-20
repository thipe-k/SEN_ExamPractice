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
    public partial class PersonMaintenanceForm : Form
    {
        Person person;
        public PersonMaintenanceForm()
        {
            InitializeComponent();
        }
        public PersonMaintenanceForm(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            person = new Person() { IdentityNumber = idNumberField.Text, 
                                    FirstName = firstNameField.Text, 
                                    Surname = surnameField.Text, 
                                    DateOFBirth = dobField.Value , 
                                    Suffix = suffixField.Text,
                                    OtherName = otherNamesField.Text,
                                    Schedule = "",
                                    Identifier = "",
                                    Title = 1};
            person.Sex = (maleOption.Checked) ? 2 : (femaleOption.Checked) ? 1 : 0;
            IList<Person> persons = person.GetPersons();
            if (persons.Count == 1)
            {
                person = persons.ElementAt(0);
            }
            else if (persons.Count > 1)
            {
                using (PersonSelectForm personSelectForm = new PersonSelectForm(persons, null))
                {
                    if (personSelectForm.ShowDialog() == DialogResult.OK)
                    {
                        person = personSelectForm.PersonObject;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Provided details has no match","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                person = null;
            }
            FillForm();
        }

        private void PersonMaintenanceForm_Load(object sender, EventArgs e)
        {
            titleField.Items.AddRange(Enum.GetNames(typeof(TitleTypes)));
            titleField.SelectedItem = TitleTypes.SelectTitle.ToString();
            FillForm();
        }
        private void FillForm()
        {
            if (person != null)
            {
                idNumberField.Text = person.IdentityNumber;
                surnameField.Text = person.Surname;
                firstNameField.Text = person.FirstName;
                otherNamesField.Text = person.OtherName;
                titleField.SelectedItem = ((TitleTypes)person.Title).ToString();
            }
        }
    }
}
