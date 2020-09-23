using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Collezioni
{
    class Liste
    {
        static void Main(string[] args)
        {
            var interi = new List<int>();
            interi.Add(1);
            interi.Add(8);
            interi.Add(3);

            foreach (int i in interi)
            {
                Console.WriteLine($"L'elemento intero vale {i}");
            }
            interi.Sort();
            foreach (int i in interi)
            {
                Console.WriteLine($"L'elemento intero vale {i}");
            }
        }
    }
}
