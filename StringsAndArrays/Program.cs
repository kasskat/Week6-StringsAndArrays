using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

           // int firstNameLenght = firstName.Length; //siia tuleb number eks sõna pikkus
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit."); //see variant sobib kuvab sama tulemust

            Console.WriteLine("Kena päeva!");
         }
    }
}
