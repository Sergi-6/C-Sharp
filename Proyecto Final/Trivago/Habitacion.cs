public class Habitacion
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public double Precio { get; set; }

    public Habitacion(int numero, string tipo, double precio)
    {
        Numero = numero;
        Tipo = tipo;
        Precio = precio;
    }
}