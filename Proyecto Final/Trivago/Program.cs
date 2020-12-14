using System;

namespace Trivago
{
    class Program
    {
        static void Main(string[] args)
        {
              Datos datos = new Datos();
            
            string opcion = "";

            while (true)
            {
                Console.Clear();

                Console.WriteLine("HOTEL TRIVAGO");
                Console.WriteLine("*************");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de habitaciones");
                Console.WriteLine("2 - Crear reservacion ");
                Console.WriteLine("3 - Lista de clientes");
                Console.WriteLine("4 - Lista de reservaciones");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarHabitaciones();
                        break;
                    case "2":
                        datos.CrearReservacion();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarReservaciones();
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
