using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheTeam
{
    class Program
    {
        public static List<Person> TeamMembers = new List<Person>();
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Would you like to create a team member? (y/n): ");
                if(Continue(Console.ReadLine()) != "n")
                {
                    Console.Clear();
                    MakeTeamMember();
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Here is a readout of all team members currently in list: ");
            foreach(TeamMember teamMember in TeamMembers)
            {
                Console.WriteLine($"\nTeam Member: {teamMember.LastName}, {teamMember.FirstName} " +
                $"\nAge: {teamMember.Age}" +
                $"\nEmail Address: {teamMember.EmailAddress}" +
                $"\nSalary: {teamMember.Salary}");
            }
            Console.WriteLine("\nGoodbye");
            Console.ReadKey();
        }

        public static void MakeTeamMember()
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
            while (!int.TryParse(Console.ReadLine(), out Age) || Age > int.MaxValue || Age < 0)
            {
                Console.Write("\nInvalid input. Please enter an appropriate age: ");
            }
            Console.WriteLine("\nNew Team Member Added!");
            Console.Clear();
            Console.Write("Salary: ");
            double Salary;
            while (!double.TryParse(Console.ReadLine(), out Salary) || Salary < 0 || Salary > double.MaxValue )
            {
                Console.Write("\nInvalid input. Please enter an appropriate salary: ");
            }
            TeamMembers = TeamMember.AddTeamMember(TeamMembers, FirstName, LastName, EmailAddress, Age, Salary);
        }

        public static string Continue(string input)
        {
            while(input != "y" && input != "n")
            {
                Console.Write("\nInvalid input. Enter either \"y\" or \"n\": ");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
