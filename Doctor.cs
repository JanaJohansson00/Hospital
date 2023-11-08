using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Doctor : Person
    {
        //Egenskaper (properties) specifikt för läkare
        public int Salary { get; set; }

        //Constructor för att skapa en läkare
        public Doctor(string name, int age, int salary)
            : base(name, age, "Doctor")
        {
            Salary = salary;
        }

        //Implementerar Introduce-metooden
        public override void Introduce()
        {
            Console.WriteLine($"I am a doctor and my name is {Name} and I am {Age} years old.");
        }

        //Implementerar DisplayInfo-metoden
        public override void DisplayInfo()
        {
            Console.WriteLine($"My salary is {Salary}.");
        }

        //En egen metod för att skriva ut medicin
        public void WritePrescription(string medication)
        {
            Console.WriteLine($"{Name} prescribes medication for {medication}.");


        }
    }
}
