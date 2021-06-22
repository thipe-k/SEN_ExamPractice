using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Diary_Management.Data_Access;
using Diary_Management.Business_Logic.CustomExceptions;

namespace Diary_Management.Business_Logic
{
    public class Person : IDiaryOwner, IComparable
    {
        private DateTime dateOFBirth;
        private string firstName;
        private string surname;
        private string identifier;
        private string identityNumber;
        private string otherName;
        private string schedule;
        private int? sex;
        private string suffix;
        private int? title;
        private string role;

        public string Info { get { return $"{firstName} {surname} ID: {identityNumber} , {suffix} {title} "; } }
        public string DisplayName { get { return $"{(TitleTypes)title} {firstName} {GetOtherNameInials()} {surname} {suffix}"; } }

        public Diary Diary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateOFBirth { get => dateOFBirth; set => dateOFBirth = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Identifier { get => identifier; set => identifier = value; }
        public string IdentityNumber { get => identityNumber; set => identityNumber = value; }
        public string OtherName { get => otherName; set => otherName = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public int? Sex { get => sex; set => sex = value; }
        public string Suffix { get => suffix; set => suffix = value; }
        public int? Title { get => title; set => title = value; }
        public string Role { get => role; set => role = value; }

        public int CompareTo(object obj)
        {
            if (obj is Person compareWith)
            {
                if (surname == compareWith.surname)
                {
                    if (firstName== compareWith.firstName)
                    {
                        if (otherName == compareWith.otherName) 
                        {
                            return suffix.CompareTo(compareWith.suffix);
                        }
                        return otherName.CompareTo(compareWith.otherName);
                    }
                    return firstName.CompareTo(compareWith.firstName);
                }
                return surname.CompareTo(compareWith.surname);
                
            }
            else { throw new NotComparableException(); }
        }
        public Person(DataRow data, bool hasRole)
        {
            dateOFBirth = DateTime.Parse(data["DateOfBirth"].ToString());
            firstName = data["FirstName"].ToString();
            surname = data["Surname"].ToString();
            identifier = data["Identifier"].ToString();
            identityNumber = data["IdentityNumber"].ToString();
            otherName = data["OtherNames"].ToString();
            schedule = data["Schedule"].ToString();
            sex = Convert.ToInt32(data["Sex"].ToString());
            suffix = data["Suffix"].ToString();
            title = Convert.ToInt32(data["Title"].ToString());

            if (hasRole)
            {
                role = data["Role"].ToString();
            }
        }
        public Person() { }
        private string GetOtherNameInials()
        {
            string[] temp = otherName.Split(' ');
            string initials = "";
            foreach (string _name in temp)
            {
                if (_name.Length>1)
                {
                    initials += $". {_name.Substring(0, 1)}";
                }
            }
         
            return initials;
        }
        public IList<Person> GetPersons()
        {
            identityNumber = (string.IsNullOrEmpty(identityNumber)) ? "0" : identityNumber;
            IList<Person> data = new  List<Person>();
            PersonDB personDB = new PersonDB();
            //  OR [OtherNames] = '{4}' OR [Schedule] = '{5}'OR [Sex] = {6} OR [Suffix] = '{7}' OR [Surname] = '{8}' OR [Title] = {9}
            foreach (DataRow rowData in personDB.GetPerson(dateOFBirth.ToString(), firstName, identifier, identityNumber, otherName, schedule, sex.ToString(), suffix, surname, title.ToString()).Rows)
            {
                data.Add(new Person(rowData,false));
            }
            return data;
        }

    }
}
