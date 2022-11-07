using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Person
    {
        string firstName;
        string lastName;
        string userDOB;
        DateTime date;

        //create constructor

        public Person(string firstName, string lastName, string userDOB)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userDOB = userDOB;

        }
        public string getDay() //using in built method DayOfWeek. Convert to string 
        {
            return date.DayOfWeek.ToString();
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }







    }
}
