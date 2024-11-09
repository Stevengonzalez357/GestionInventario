using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            Console.WriteLine("Bienvenido al sistema de gestión de inventario de productos");

            while (true)
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Actualizar precio de producto");
                Console.WriteLine("3. Eliminar producto");
                Console.WriteLine("4. Filtrar y mostrar productos por precio mínimo");
                Console.WriteLine("5. Contar y agrupar productos por precio");
                Console.WriteLine("6. Generar reporte de inventario");
                Console.WriteLine("7. Salir");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el precio del producto: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal precio))
                        {
                            Producto producto = new Producto(nombre, precio);
                            inventario.AgregarProducto(producto);
                        }
                        else
                        {
                            Console.WriteLine("Error: El precio ingresado no es válido.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese el nombre del producto a actualizar: ");
                        string nombreActualizar = Console.ReadLine();
                        Console.Write("Ingrese el nuevo precio: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nuevoPrecio))
                        {
                            inventario.ActualizarPrecioProducto(nombreActualizar, nuevoPrecio);
                        }
                        else
                        {
                            Console.WriteLine("Error: El precio ingresado no es válido.");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre del producto a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        inventario.EliminarProducto(nombreEliminar);
                        break;

                    case "4":
                        Console.Write("Ingrese el precio mínimo para filtrar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal precioMinimo))
                        {
                            var productosFiltrados = inventario.FiltrarYOrdenarProductos(precioMinimo);
                            Console.WriteLine("\nProductos filtrados y ordenados:");
                            foreach (var producto in productosFiltrados)
                            {
                                producto.MostrarInformacion();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: El precio ingresado no es válido.");
                        }
                        break;

                    case "5":
                        inventario.ContarAgruparProductosPorPrecio();
                        break;

                    case "6":
                        inventario.GenerarReporte();
                        break;

                    case "7":
                        Console.WriteLine("Saliendo del sistema...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
