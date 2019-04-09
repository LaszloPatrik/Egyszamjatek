using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Egyszamjatek
{
    class Program
    {
        static List<Jatekosok> jatekos;
        static int fordulo;

        static void Main(string[] args)
        {
            Beolvas();
            Feladat03();
            Feladat04();
            Feladat05();

            Console.ReadKey();
        }

        private static void Feladat05()
        {
            double ossz = 0;

            for (int i = 0; i < jatekos.Count; i++)
            {
                ossz += jatekos[i].tipps[fordulo - 1];
            }

            double atlag = ossz / jatekos.Count;

            Console.WriteLine("5. feladat: A megadott forduló tippjeinek átlaga: {0:F2} ", atlag);

        }

        private static void Feladat04()
        {
            Console.Write("4. feladat: Kérem a forduló számát: ");
            fordulo = int.Parse(Console.ReadLine());
            
        }

        private static void Feladat03()
        {
            Console.WriteLine("3. feladat: Játékosok száma: {0} fő", jatekos.Count);
        }

        private static void Beolvas()
        {
            jatekos = new List<Jatekosok>();

            var sr = new StreamReader(@"egyszamjatek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                jatekos.Add(new Jatekosok(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
