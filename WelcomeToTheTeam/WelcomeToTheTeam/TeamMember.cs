using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheTeam
{
    class TeamMember : Person
    {
        private double _salary;
        private string _address;
        
        public double Salary
        {
            get { return _salary; }
        }

        public TeamMember(string firstName, string lastName, int age, string emailAddress, double salary, string address) : base(firstName, lastName, age, emailAddress)
        {
             _salary = salary;
            _address = address;
        }


        public static List<Person> AddTeamMember(List<Person> Persons, string firstName, string lastName, string emailAddress, int age, double salary)
        {
            List<Person> sublist = Persons;
            sublist.Add(new TeamMember(firstName, lastName, age, emailAddress, salary, ""));
            return sublist;
        }
    }
}
