using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario
{
    public class Inventario
    {
        private List<Producto> productos;

        public Inventario()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                Console.WriteLine("Error: El nombre del producto no puede estar vacío.");
                return;
            }

            if (producto.Precio <= 0)
            {
                Console.WriteLine("Error: El precio del producto debe ser un valor positivo.");
                return;
            }

            productos.Add(producto);

        }
    }
}
   
