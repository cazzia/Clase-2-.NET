using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaWebEntities db = new TiendaWebEntities();
            //Categories categoria = new Categories();
            //categoria.Name = "Ferreteria";
            //db.Categories.Add(categoria);
            ////db.SaveChanges();
            //Products producto = new Products();
            //producto.Name = "Clavo";
            //producto.Price = 10;
            //producto.Categories.Add(categoria);
            //db.Products.Add(producto);

            Products producto = new Products();
            producto.Name = "Protector Solar 100";
            Categories categoria = new Categories();
            categoria.Name = "Productos de belleza";

            //producto.Categories.Add(categoria);
            categoria.Products.Add(producto);

            db.Products.Add(producto);
            //db.Categories.Add(categoria);

            db.SaveChanges();


        }
    }
}
