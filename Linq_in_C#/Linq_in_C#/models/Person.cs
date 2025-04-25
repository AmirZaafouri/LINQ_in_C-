using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_.POCO
{
    public class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Default Constructor
        public Person() { }

        // All-Args Constructor
        public Person(int id, string firstName, string lastName, string email, string gender, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            Age = age;
        }

        // Overriding ToString() method
        public override string ToString()
        {
            return $"Person[Id={Id}, FirstName={FirstName}, LastName={LastName}, Email={Email}, Gender={Gender}, Age={Age}]";
        }
    }
}
