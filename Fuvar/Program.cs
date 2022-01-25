using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuvar
{
    class Program
    {
        class taxi
        {
            public string id;
            public int indulas;
            public int idotartam;
            public int tavolsag;
            public int viteldij;
            public int borravalo;
            public string fizetes;
        }
        public taxi(string sor)
        {

            string[] d = sor.Split(';');
            string id = d[0];
            int indulas = int.Parse(d[1]);

        }

        static void Main(string[] args)
        {

            //taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja
            Console.ReadKey();

        }
    }
}
