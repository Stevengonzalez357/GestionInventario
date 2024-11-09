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
            }
        }
    }
}
