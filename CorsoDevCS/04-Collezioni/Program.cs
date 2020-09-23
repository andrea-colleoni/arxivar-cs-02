using System;

namespace _04_Collezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] interi = new int[10];
            interi[0] = 5;
            interi[1] = 6;
            interi[2] = 6;
            interi[3] = 6;
            interi[4] = 6;
            interi[5] = 6;
            interi[6] = 6;

            string[] nomi = { "Andrea", "Anna", "Mario", "Luigi" };

            foreach(int i in interi)
            {
                Console.WriteLine($"L'elemento intero vale {i}");
            }

            foreach (string s in nomi)
            {
                Console.WriteLine($"L'elemento stringa vale {s}");
            }

        }
    }
}
