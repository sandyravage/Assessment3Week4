using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheTeam
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _emailAddress;
        private bool _isAnAdult;

        public Person(string firstName, string lastName, int age, string emailAddress)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;            
            _emailAddress = emailAddress;
            _isAnAdult = IsAdult();
        }

        public string FirstName
        {
            get { return _firstName; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public int Age
        {
            get { return _age; }
        }
        public string EmailAddress
        {
            get { return _emailAddress; }
        }

        public bool IsAdult()
        {
            if (_age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Person> AddPerson(List<Person> Persons, string firstName, string lastName, string emailAddress, int age)
        {
            List<Person> sublist = Persons;
            if(age >= 18)
            {
                sublist.Add(new Person(firstName, lastName, age, emailAddress));
            }
            else
            {
                Console.WriteLine("\nPerson is not over 18 and cannot be added to list.\n");
            }
            return sublist;
        }
    }
}
