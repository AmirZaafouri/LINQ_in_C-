using Linq_in_C_.MockData;
using Linq_in_C_.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Linq_in_C_.main
{
    public class Reason
    {
       /* [Fact]
        public void FindPeople()
        {
            // 1. Find people aged less than or equal to 18
            // 2. Then change implementation to find first 10 people
            List<Person> people = MockData.MockData.GetPeople();
            List<Person> youngPeople = new List<Person>();
            int limit = 10;
            int count = 0;

            foreach (var person in people)
            {
                if (person.Age <= 18)
                {
                    youngPeople.Add(person);
                    count++;
                }
                if (limit == count)
                    break;
            }

            youngPeople.ForEach(p => Console.WriteLine(p.ToString()));
        }

        [Fact]
        public void FindPeopleWithLinq()
        {
            // 1. Find people aged less than or equal to 18
            // 2. Then change implementation to find first 10 people
            List<Person> people = MockData.MockData.GetPeople();
            var youngPeople = people
                .Where(p => p.Age <= 18)    // LINQ filter equivalent to stream's filter
                .Take(10)                   // Limit to 10 items
                .ToList();

            youngPeople.ForEach(p => Console.WriteLine(p.ToString()));
        }*/
    }
}
