using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees ja perekonnanime
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikkem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi: ");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length;

            Console.WriteLine("Sisesta oma perekonnanimi: ");
            string lastName = Console.ReadLine();

            int lastNameLenght = lastName.Length;

            if (firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Sinu eesnimi on pikkem, kui perekonnanimi.");
            }
            else if (firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Sinu perekonnanimi on pikkem, kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanime pikkus on võrdne.");
            }

        }
    }
}
