using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Collezioni
{
    class Dizionari
    {
        static void Main(string[] args)
        {
            var mesi = new Dictionary<string, string>();
            mesi.Add("jan", "gennaio");
            mesi.Add("feb", "febbraio");
            mesi.Add("mar", "marzo");
            mesi.Add("apr", "aprile");
            mesi.Add("may", "maggio");
            mesi.Add("jun", "giugno");

            Console.WriteLine(mesi["sep"]);
        }
    }
}
