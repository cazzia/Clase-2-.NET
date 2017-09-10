using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
         

            List<Conectarse> tipoConexion = new List<Conectarse>();
            Conectarse primeraConexion = new Lampara();
            tipoConexion.Add(primeraConexion);
            Conectarse segundaConexion = new Radio();
            tipoConexion.Add(segundaConexion);
            Conectarse terceraConexion = new Televisor();
            tipoConexion.Add(terceraConexion);

            tipoConexion.ForEach(x => x.DecirConexion());

            
            Console.ReadLine();

        }
    }
}
