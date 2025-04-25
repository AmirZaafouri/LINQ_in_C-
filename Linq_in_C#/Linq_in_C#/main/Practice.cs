using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_.main
{
    public class Practice
    {
        private static string data = """
            16,Fanchette,Williamson,fwilliamson0@github.com,F
            26,Aleksandr,Matts,amatts1@webs.com,M
            3,Maurie,Cordero,mcordero2@google.co.jp,M
            45,Donnajean,Crowson,dcrowson3@google.com.hk,F
            5,Ricardo,Gofton,rgofton4@nytimes.com,M
            65,Gabie,Tregenna,gtregenna5@guardian.co.uk,F
            37,Marjorie,Blumsom,mblumsom6@joomla.org,F
            18,Lester,Huyghe,lhuyghe7@jugem.jp,M
            39,Merrily,Stangoe,mstangoe8@tiny.cc,F
            10,Reider,Karel,rkarel9@github.io,M
            11,Dory,Jolliff,djolliffa@wufoo.com,F
            32,Homerus,Averay,haverayb@skyrock.com,M
            13,Alyda,Muglestone,amuglestonec@is.gd,F
            14,Pinchas,Louca,ploucad@google.es,M
            11,Cherin,Eltringham,celtringhame@parallels.com,F
            2,Mufi,Rothert,mrothertf@dropbox.com,F
            17,Jordana,Everex,jeverexg@ucla.edu,F
            18,Belle,Rother,brotherh@gov.uk,F
            19,Clevie,Sifflett,csiffletti@furl.net,M
            20,Gretchen,Abell,gabellj@1688.com,F
        """;

        public static void HandleStringOp()
        {
            var people = data.Split("\n", StringSplitOptions.RemoveEmptyEntries)
                .Select(MapPerson)
                .Where(p => p.Gender == Gender.F)
                .Where(p => p.Age >= 13 && p.Age <= 19)
                .Where(p => p.Email.EndsWith("gov.uk"))
                .ToList();

            people.ForEach(Console.WriteLine);
        }

        public static Person MapPerson(string line)
        {
            var parts = line.Trim().Split(',');
            int age = int.Parse(parts[0]);
            string firstName = parts[1];
            string lastName = parts[2];
            string email = parts[3];
            Gender gender = Enum.Parse<Gender>(parts[4]);

            return new Person(firstName, lastName, email, age, gender);
        }


        public enum Gender
        {
            M, F
        }

        public class Person
        {
            public string FirstName { get; }
            public string LastName { get; }
            public string Email { get; }
            public int Age { get; }
            public Gender Gender { get; }

            public Person(string firstName, string lastName, string email, int age, Gender gender)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                Age = age;
                Gender = gender;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName} (Age: {Age}, Email: {Email}, Gender: {Gender})";
            }
        }
    }
   
}
