using System;
public class DireccionTecnica: Empleado // -> Herencia
{
    public string Puesto { get; set; }

    public void PerfilDT() // -> Abstraccion
    {
        Console.WriteLine("Perfil:");
        Console.WriteLine("-------");
        Equipos();
        Titulos();
    }

    private void Equipos() // -> Encapsulamiento
    {
        Console.WriteLine("Equipos:");
        Console.WriteLine("CD  Faz - El Salvador");
        Console.WriteLine("CD  Real España - Honduras");
    }
    private void Titulos() // -> Encapsulamiento
    {
        Console.WriteLine("Palmares:");
        Console.WriteLine("Liga Salvadoreña - CD Faz");
    }
}

