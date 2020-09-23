using System;

namespace _02_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nome = "Mario";
            p1.Cognome = "Rossi";

            p1.StampaDatiAnagrafici();

            Persona p2 = new Persona();
            p2.Nome = "Anna";
            p2.Cognome = "Verdi";

            p2.StampaDatiAnagrafici();

            p2 = p1;
            p2.Nome += "***";

            p1.StampaDatiAnagrafici();

            Console.ReadLine();
        }
    }
}
