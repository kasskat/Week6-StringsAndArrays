using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            string helloW = "Hello World!";

            string helloWLow = helloW.ToLower();

            int stringLenght = helloWLow.Length;

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWLow.Length; i++)
            {
                if (helloWLow[i] == 'h')
                {
                    hCounter++;
                }
                else if (helloWLow[i] == 'o')
                {
                    oCounter++;
                }
                else if (helloWLow[i] == 'l')
                {
                    lCounter++;
                }
            }

           
            Console.WriteLine($"Lauses 'Hello World!' on {hCounter} h-t, {oCounter} o-t, {lCounter} l-i.");
            
           
            
        }
    }
}
