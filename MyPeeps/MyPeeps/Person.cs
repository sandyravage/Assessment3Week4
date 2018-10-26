using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps
{
    class Person
    {
        private string FirstName;
        private string LastName;
        private int Age;
        private string EmailAddress;
        private bool IsAnAdult;

        public Person(string firstName, string lastName, int age, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            EmailAddress = emailAddress;
            IsAnAdult = IsAdult();
        }

        public bool IsAdult()
        {
            if (Age >= 18)
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
