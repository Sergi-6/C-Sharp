using System;

namespace _10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            
            string opcion = "";

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Sistema de ordenes");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Crear orden ");
                Console.WriteLine("3 - Lista de clientes");
                Console.WriteLine("4 - Lista de vendedores");
                Console.WriteLine("5 - Lista de ordenes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearOrden();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarVendedores();
                        break;
                    case "5":
                        datos.ListarOrdenes();
                        break;

                    default:
                        break;
                }

                if (opcion == "0")
                {
                    break;
                }
            }
        }
    }
}
