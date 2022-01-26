using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.Jmeno = "Zdeněk";
            osoba.Prijmeni = "Jendřejčík";
            osoba.DatumNarozeni = DateTime.Parse("01.04.2003");

            Console.WriteLine(osoba.GetVek());
            Console.ReadKey();
        
        
        }
    }
}
