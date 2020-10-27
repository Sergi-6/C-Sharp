public class Producto
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public int Existencia { get; set; }
    public double Precio { get; set; }

    public Producto(string codigo, string descripcion, int existencia, int precio)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;
        Precio = precio;
    }

}