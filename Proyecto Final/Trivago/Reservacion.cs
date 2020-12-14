using System;
using System.Collections.Generic;
public class Reservacion 
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeReservacion { get; set; }
    public Cliente cliente { get; set; }
    public double Total { get; set; }
    public List<ReservacionDetalle> ListaReservacionDetalle { get; set; }
    public Cliente Cliente { get; }
    

    public Reservacion(int codigo, DateTime fecha, string numerodeReservacion, Cliente cliente)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeReservacion = numerodeReservacion;
        ListaReservacionDetalle = new List<ReservacionDetalle>();
        Cliente = cliente;


    }
    

    public void AgregarHabitacion(Habitacion habitacion)
    {
        int nuevoCodigo = ListaReservacionDetalle.Count + 1;
        

        ReservacionDetalle r = new ReservacionDetalle(nuevoCodigo, habitacion);
        ListaReservacionDetalle.Add(r);

        Total = habitacion.Precio; 
    }

    
}