using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_szerkezet
{
    class DiakBeker
    {
        public string Nev { get; set; }
        public int EletKor { get; set; }
        public DiakBeker(string nev, int eltkor)
        {
            this.Nev = nev;
            this.EletKor = eltkor;

        }

        public void AdatKiir()
        {
            Console.WriteLine($"Nev:{this}")
        }
    }
}
