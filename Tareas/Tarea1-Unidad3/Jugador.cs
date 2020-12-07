using System;
public class Jugador: Empleado // -> Herencia
{
    public int Dorsal { get; set; }
    public string Posicion { get; set; }
    public double Estatura { get; set; }
    public double Peso { get; set; }

    public void Disponible() // -> Abstraccion
    {
        Console.WriteLine("Este jugador esta listo para jugar.");
    }

    public void Lesion()
    {
        Console.WriteLine("Este jugador esta lesionado, no tendra participacion en el proximo partido.");
    }

    public void Sansion()
    {
        Console.WriteLine("Este jugador esta sansionado, no tendra participacion en el proximo partido.");
    }
}