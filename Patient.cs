using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient : Person
    {
        //Egenskaper (properties) för patient
        public string Diagnosis { get; set; }
        public string Medication { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        //Constructor för att skapa en patient
        public Patient (string name, int age, string diagnosis, string medication, DateTime checkInDate, DateTime checkOutDate)
            : base(name, age, "Patient")
        {
            Diagnosis = diagnosis;
            Medication = medication;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;

        }

        //Implementerar Introduce-metoden
        public override void Introduce()
        {
            Console.WriteLine($"I am {Name} and I am {Age} years old.");
        }

        //Överlagrad metod för att visa info om patient
        public override void DisplayInfo()
        {
            Console.WriteLine($"Diagnosis: {Diagnosis}.");
            if (!string.IsNullOrEmpty(Medication))
            {
                Console.WriteLine($"Medication that is given {Medication}.");
            }
            else
            {
                Console.WriteLine("No medication is given");
            }
            Console.WriteLine($"Check-in Date: {CheckInDate}");
            Console.WriteLine($"Check-out Date: {CheckOutDate}");
        }

        //Metod för att checka in på sjukhuset
        public void AdmitToHospital(DateTime checkInDate)
        {
            CheckInDate = checkInDate;
            Console.WriteLine($"{Name} have checked into the hospital with the diagnosis {Diagnosis}.");
        }

        //Metod för att checka ut från sjukhuset
        public void DischargeFromHospital(DateTime checkOutDate)
        {
            CheckOutDate = checkOutDate;
            Console.WriteLine($"{Name} has been checked out from the hospital.");
        }
    }
}
