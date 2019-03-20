using System;

namespace ooad_t1_z7
{
    class Program
    {
        public static void ispravanUnos(String unos, out int broj)
        {
            while (Int32.TryParse(Console.ReadLine(), out broj) == false)
                Console.WriteLine("neispravan unos, unesite ponovo");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj rijeci koje zelite unijeti:");
            int brojRijeci;
            ispravanUnos(String.Empty, out brojRijeci);

            String[] nizRijeci = new string[brojRijeci];
            String[] razdjeljenoUzasebeneRijeci = Console.ReadLine().Split(' ', '\n', '\t', ',');

            for (int i = 0; i < brojRijeci; i++)
                nizRijeci[i] = razdjeljenoUzasebeneRijeci[i];

            ispisiNizRijeci(nizRijeci);
            sortirajNizStringova(nizRijeci);
            ispisiNizRijeci(nizRijeci);

            Console.ReadLine();
        }

        private static void ispisiNizRijeci(string[] nizRijeci)
        {
            for (int i = 0; i < nizRijeci.Length; i++)
            {
                Console.Write("{0}", nizRijeci[i]);

                if (i != nizRijeci.Length - 1)
                    Console.WriteLine(", ");
            }
        }

        private static void sortirajNizStringova(string[] nizRijeci)
        {

            for (int i = 0; i < nizRijeci.Length; i++)
            {
                int najmanji = i;

                for (int j = i + 1; j < nizRijeci.Length; j++)
                {
                    // NETACAN USLOV, NE NMOGU VISE AAAAAAAAAAA
                    if (nizRijeci[najmanji].CompareTo(nizRijeci[j]) < 1)
                        najmanji = j;
                }

                String tmp = nizRijeci[i];
                nizRijeci[i] = nizRijeci[najmanji];
                nizRijeci[najmanji] = tmp;
            }
        }
    }
}
