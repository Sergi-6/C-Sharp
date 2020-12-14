using System;
using System.Collections.Generic;
public class Datos
{
    private readonly Habitacion habitacion;

    public List<Habitacion> ListadeHabitaciones { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Reservacion> ListaReservaciones { get; set; }
    public ReservacionDetalle D { get; set; }

    public Datos()
    {
        ListadeHabitaciones = new List<Habitacion>();
        CargarHabitaciones();

        ListadeClientes = new List<Cliente>();
        CargarClientes();

        ListaReservaciones = new List<Reservacion>();
    }

    private void CargarHabitaciones()
    {
        Habitacion h1 = new Habitacion (01, "Suite Junior", 500);
        ListadeHabitaciones.Add(h1);

        Habitacion h2 = new Habitacion (02, "Suite Personal", 1000);
        ListadeHabitaciones.Add(h2);

        Habitacion h3 = new Habitacion (03, "Suite Doble", 1500);
        ListadeHabitaciones.Add(h3);

    }

    private void CargarClientes()
    {
        Cliente c1 = new Cliente (01, "Juan Ramirez", "+504 3287-1257");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente (02, "Raquel Regalado", "+504 3358-5321");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente (03, "Sergi Flores", "+504 9817-1339");
        ListadeClientes.Add(c3);
    }

    public void ListarHabitaciones()
    {
        Console.Clear();
        Console.WriteLine("Lista de habitaciones");
        Console.WriteLine("==================");
        Console.WriteLine("");

        foreach (var Habitacion in ListadeHabitaciones)
        {
            Console.WriteLine(Habitacion.Numero + " | " + Habitacion.Tipo + " | " + Habitacion.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de clientes");
        Console.WriteLine("==================");
        Console.WriteLine("");

        foreach (var Cliente in ListadeClientes)
        {
            Console.WriteLine(Cliente.Codigo + " | " + Cliente.Nombre + " | " + Cliente.Telefono);
        }

        Console.ReadLine();
    }

    

    public void CrearReservacion()
    {
        Console.WriteLine("Creando reservacion");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese codigo de cliente:");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);
        if (cliente == null)
        {
            Console.WriteLine("Agregando cliente nuevo...");
        } else
        {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaReservaciones.Count + 1;

        Reservacion nuevaReservacion = new Reservacion(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente);
        ListaReservaciones.Add(nuevaReservacion);

       while (true)
       {
        Console.WriteLine("Ingrese numero de habitacion");
        string numeroHabitacion = Console.ReadLine();

        Habitacion habitacion = ListadeHabitaciones.Find(h => h.Numero.ToString() == numeroHabitacion);
        if (habitacion == null)
        {
            Console.WriteLine("Habitacion no disponile!");

        }else
        {
            Console.WriteLine("Numero de habitacion: " + habitacion.Numero + " | " + habitacion.Tipo + "| Precio: " + habitacion.Precio );
            nuevaReservacion.AgregarHabitacion(habitacion);
        }
            break;
       }
    
        
        Console.WriteLine("");
        Console.WriteLine("El total de la reservacion es de: " );
        Console.WriteLine(nuevaReservacion.Total);
        Console.ReadLine();   
    }

    public void ListarReservaciones()
    {
        Console.Clear();
        Console.WriteLine("Lista de reservaciones");
        Console.WriteLine("==================");
        Console.WriteLine("");
        Console.WriteLine("Codigo | Fecha | Total");
        Console.WriteLine("Cliente");
        Console.WriteLine("==================");
        Console.WriteLine(""); 

        foreach (var reservacion in ListaReservaciones)
        {
            Console.WriteLine(reservacion.Codigo + " | " + reservacion.Fecha + " | " + reservacion.Total);
            Console.WriteLine(reservacion.Cliente.Nombre );
        }
        Console.ReadLine();
    }
}
