using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps
{
    class Program
    {
        public static List<Person> Persons = new List<Person>();

        static void Main()
        {
            MakePerson();
            Console.ReadKey();
        }

        public static void MakePerson()
        {
            Console.Write("Please enter the following data to create a new person: " +
                "\nFirst Name: ");
            string FirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();
            Console.Clear();
            Console.Write("Email Address: ");
            string EmailAddress = Console.ReadLine();
            Console.Clear();
            Console.Write("Age: ");
            int Age;
                while (!int.TryParse(Console.ReadLine(), out Age) || Age > 120 || Age < 0)
                {
                    Console.Write("\nInvalid input. Please enter an appropriate age: ");
                }
            Console.WriteLine("\nNew Person Added!");
            Persons = Person.AddPerson(Persons, FirstName, LastName, EmailAddress, Age);
        }
    }
}
