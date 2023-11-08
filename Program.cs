namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar en lista för sjukhuspersonal
            List<Person> hospitalStaff =new List<Person>
            {
                new Doctor ("Dr Marley Grey", 45,85000),
                new Nurse ("Sara Lee", 23, "Night"),
                new Nurse("Peter Lo", 37, "Day")
            };

            Console.WriteLine("Staff at the hospital");
            foreach (var person in hospitalStaff)
            {
                person.Introduce(); //Anropar Introduce-metoden för varje person
                person.DisplayInfo(); //Anropar DisplayInfo-metoden för att visa specifik info
                Console.WriteLine();
            }

            //Skapar en lista för patienter
            List<Patient> patients = new List<Patient>
            {
                new Patient("Jana Johansson", 23, "Stomach ache", "Lactiplus", DateTime.Now, DateTime.Now.AddDays(7)),
                new Patient("Burt Loo", 65, "Broken leg", "Aspirin", DateTime.Now, DateTime.Now.AddDays(4))
            };

            Console.WriteLine("\nPatients in the hospital:");
            foreach (var patient in patients)
            {
                patient.Introduce(); //Anropar Introduce-metoden för varje patient
                patient.DisplayInfo(); //Anropar DisplayInfo-metoden för att visa specifik info
                Console.WriteLine();

            }

        }
    }
}