using System;

namespace _01_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // variabili, operatori, tipi
            int a; // dichiarazione
            a = 10; // assegnazione

            float b = 20.4F; // dichiarazione + assegnazione
            // 20.4: è un valore (literal) => se non specifico nulla un numero col punto decimale è 
            //       considerato un double; senza . decinale è un int
            double c = 10.5;

            long d = 11;
            // int e = 10L;

            bool x = true; // true, false
            decimal k = 10.7M;

            char t = 't'; // delimitatore '

            string s = "ciao"; // delimitatore "

            // controllo di flusso: branching, looping, call (jump)
            Console.WriteLine("-------------");
            // 1. branching (if, switch)
            if ( c > d ) // la condizione deve essere un bool
            {
                Console.WriteLine("c è maggiore di d");
            } 
            else if ( a < k )
            {
                Console.WriteLine("a è minore di k");
            }
            else
            {
                Console.WriteLine("c NON è maggiore di d");
            }
            Console.WriteLine("-------------");
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("a è 1, 2 o 3");
                    break;
                case 4:
                    Console.WriteLine("a è 4");
                    break;
                default:
                    Console.WriteLine("a NON è né 1, 2, 3 né 4");
                    break;
            }
            Console.WriteLine("-------------");
            // loop for, while (do .. while), foreach (più avanti)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            // a questo punto a vale 10 (l'ho inizializzata all'inizio)
            while(a > 0)
            {
                Console.WriteLine(a--);
            }

            // call
            Console.WriteLine( Metodo() );

            // permette alla console di rimanere il attesa della pressione del tasto ENTER
            Console.ReadLine();
        }

        static int Metodo()
        {
            return Metodo2();
        }

        static int Metodo2()
        {
            return Metodo3();
        }

        static int Metodo3()
        {
            return 10;
        }

    }
}
