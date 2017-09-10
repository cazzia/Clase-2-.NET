using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    public class Lampara : Electrodomesticos, Conectarse
    {

     

        public void DecirConexion()
        {
            Console.WriteLine("Soy Lampara, me conecto por enchufe redondo o plano");
        }

    
    }
}
