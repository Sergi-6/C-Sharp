public class ReservacionDetalle
{
    public int Codigo { get; set; }
    public double Precio { get; set; }
    public Habitacion habitacion { get; set; }

    public ReservacionDetalle(int codigo, Habitacion habitacion)
    {
        Codigo = codigo;
        
          
    }
}