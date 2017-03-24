using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() {
                FirstName = "Bruno",
                LastName = "Barrette"
            };

            Console.WriteLine(string.Format("Mon nom est {0} {1}", person.FirstName, person.LastName));
            
            Console.ReadKey();
        }

        private static void UsingObjectInitializerRefactoring()
        {
            var person = new Person();

            person.FirstName = "Bruno";
            person.LastName = "Barrette";
            person.Address = "111 Test";
            person.City = "Laval";
            person.Province = "Quebec";
            person.PostalCode = "H7V4B3";
            person.Country = "Canada";
        }

        private static void InlineVariableDeclarationRefactoring(string birthDate)
        {
            var person = new Person()
            {
                FirstName = "Bruno",
                LastName = "Barrette"
            };

            DateTime parsedBirthDate;
            if (DateTime.TryParse(birthDate, out parsedBirthDate))
            {
                person.BirthDate = parsedBirthDate;
            }
        }

        private static Person CreatePersonFromName(string firstName, string lastName)
        {
            var person = new Person();

            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }            
            if (lastName == null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            person.FirstName = firstName;
            person.LastName = lastName;

            return person;
        }

    }

    public class ClassThatDoesNotBelongInProgram
    {

    }

}
