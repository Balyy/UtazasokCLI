using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasokCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            UtazasRepository.Path = "utazasok.csv";

            foreach (var item in UtazasRepository.FindAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(UtazasRepository.FindById(5));

            Utazas ujUtazas = new Utazas()
            {
                Id = 0,
                Orszag = "Kuba",
                Honap = 7,
                Nap = 13,
                Hossz = 7,
                Ar = 300000,
                Ellatas = "félpanzió"
            };

            UtazasRepository.Save(ujUtazas);

            Console.WriteLine("utazasok.csv új elemmel: ");
            foreach (var item in UtazasRepository.FindAll())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
