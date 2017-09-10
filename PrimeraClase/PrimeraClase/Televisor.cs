using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Televisor : Electrodomesticos, Conectarse
    {
     

        public void DecirConexion()
        {
            Console.WriteLine("Soy televisor, me conecto por enchufe plano");
        }
    }
}
