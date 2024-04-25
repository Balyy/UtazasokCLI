using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasokCLI
{
    class Utazas
    {
        public int Id { get; set; }
        public string Orszag { get; set; }
        public int Honap { get; set; }
        public int Nap { get; set; }
        public int Hossz { get; set; }
        public int Ar { get; set; }
        public string Ellatas { get; set; }

        public override string ToString()
        {
            return $"Utazas<{Id};{Orszag};{Honap};{Nap};{Hossz};{Ar};{Ellatas}>";
        }

        public string ToCSVLine()
        {
            return $"{Id},{Orszag},{Honap},{Nap},{Hossz},{Ar},{Ellatas}";
        }

        public static Utazas CreateFromLine(string line, char separator)
        {
            string[] values = line.Split(separator);

            return new Utazas()
            {
                Id = int.Parse(values[0]),
                Orszag = values[1],
                Honap = int.Parse(values[2]),
                Nap = int.Parse(values[3]),
                Hossz = int.Parse(values[4]),
                Ar = int.Parse(values[5]),
                Ellatas = values[6]
            };
        }
    }
}
