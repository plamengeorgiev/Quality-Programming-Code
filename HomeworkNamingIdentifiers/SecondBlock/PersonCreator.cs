using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCodeBlock
{
    class PersonCreator
    {
        enum Gender { male, female };

        class Person
        {
            public Gender Sex { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreatePerson(int age)
        {
            Person firstPerson = new Person();
            firstPerson.Age = age;
            if (age % 2 == 0)
            {
                firstPerson.Name = "The Man";
                firstPerson.Sex = Gender.male;
            }
            else
            {
                firstPerson.Name = "The Chick";
                firstPerson.Sex = Gender.female;
            }
        }
    }
}
