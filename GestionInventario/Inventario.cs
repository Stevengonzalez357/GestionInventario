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

        public IEnumerable<Producto> FiltrarYOrdenarProductos(decimal precioMinimo)
        {
            return productos.Where(p => p.Precio >= precioMinimo).OrderBy(p => p.Precio);
        }

        public bool ActualizarPrecioProducto(string nombre, decimal nuevoPrecio)
        {
            var producto = productos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (producto != null)
            {
                if (nuevoPrecio > 0)
                {
                    producto.Precio = nuevoPrecio;
                    Console.WriteLine("Precio actualizado correctamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Error: El precio debe ser positivo.");
                }
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
            return false;

        }

    }
}
   
