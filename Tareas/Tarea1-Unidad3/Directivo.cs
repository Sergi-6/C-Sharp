public class Directivo: Empleado // -> Herencia
{
    public string Cargo { get; set; }
    public bool Inactivo { get; set; }

    public Directivo() // -> Polimorfismo
    {
        Inactivo = true;
    }
    public Directivo(bool inactivo)  // -> Polimorfismo
    {
        Inactivo = inactivo;
    }
}
