using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Person
    {
        //Egenskaper (properties) för varje prson
        public string Name { get; set; }
        public int Age { get; set; }

        public string Occupation { get; set; }

        //Constructor för att skapa en person
        public Person (string name, int age, string occupation)
        {
            Name = name;
            Age = age;
            Occupation = occupation;

        }

        //Abstrakta metoder som måste implementeras i underliggande klasser
        public virtual void Introduce()
        {
            Console.WriteLine($"My name is {Name} and I am {Age} years old.");
            Console.WriteLine($"I am a {Occupation}");
        }

        public abstract void DisplayInfo();

    }
}
