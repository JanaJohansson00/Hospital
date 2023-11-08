using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Nurse : Person
    {
        //Egenskaper (properties) specifika för sjuksköterska
        public string Shift { get; set; }

        //Constructor för att skapa en sjuksköterska
        public Nurse(string name, int age, string shift)
            :base(name, age, "Nurse")
        {
            Shift = shift;
        }

        //Implementerar Introduce-metoden
        public override void Introduce()
        {
            Console.WriteLine($"I am a nurse and my name is {Name} and I am a {Age} years old.");
        }

        //Implementerar DisplayInfo-metoden
        public override void DisplayInfo()
        {
            Console.WriteLine($"I work {Shift} shift.");
        }

        //Egen metod för att ta blodprov
        public void TakeBloodTest()
        {
            Console.WriteLine($"{Name} takes a bloodtest during the {Shift} -shift.");
        }
    }
}
