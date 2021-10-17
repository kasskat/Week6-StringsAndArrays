using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga (0)
            //prpgramm asendab kõik 'a' tähed samas lauses neljaga (4)

            string dpanic = "Don't Panic!";

            dpanic = dpanic.Replace('o', '0');
            dpanic = dpanic.Replace('a', '4');

            Console.WriteLine(dpanic);

        }
    }
}
