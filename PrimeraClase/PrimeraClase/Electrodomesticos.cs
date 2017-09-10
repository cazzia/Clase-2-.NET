using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    public class Electrodomesticos
    {
        public String Codigo { get; set; }
        public String Descripcion { get; set;  }
        public double Precio { get; set; }

        //public Electrodomesticos(string codigo, string descripcion, double precio)
        //{
        //    this.Codigo = codigo;
        //    this.Descripcion = descripcion;
        //    this.Precio = precio;
        //}


        public void TipoProducto()
        {
            Console.WriteLine($"Mi codigo de producto es {Codigo}/n , Descripcion :{Descripcion}/n , Precio  : {Precio} ");
                
        }
    }
}
