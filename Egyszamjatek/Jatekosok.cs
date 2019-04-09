using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyszamjatek
{
    class Jatekosok
    {
        public string nev;
        public int[] tipps;

        public Jatekosok(string sor)
        {
            var t = sor.Split(' ');

            this.nev = t[0];
            this.tipps = new int[t.Length - 1];

            for (int i = 0; i < this.tipps.Length; i++)
            {
                tipps[i] = int.Parse(t[i + 1]);
            }
        }
    }
}
