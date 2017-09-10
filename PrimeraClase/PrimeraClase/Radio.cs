using System;

namespace PrimeraClase
{
    class Radio : Electrodomesticos, Conectarse
    {
   
        public void DecirConexion()
        {

            Console.WriteLine("Soy Radio, me conecto por enchufe redondo ");
        }
    }
}
