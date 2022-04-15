using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "TestFornavn";
            LastName = "TestEtternavn";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string ShowFullName()
        {
            string fullName;
            fullName = FirstName + " " + LastName;
            return fullName;
        }
    }
}
