using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_szerkezet
{
    class Program
    {
        static void Main(string[] args)
        {
            DiakBeker diak = new DiakBeker("Márkus Regő", 14);

            Console.WriteLine(diak.Nev);
            Console.WriteLine(diak.EletKor);

            Console.ReadKey(true);
        }
    }
}
