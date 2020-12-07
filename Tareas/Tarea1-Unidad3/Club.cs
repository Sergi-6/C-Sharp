using System;
public class Club
{
    public void Informacion() // -> Abstraccion
    {
        Console.WriteLine("Historia:");
        Historia();
        Console.WriteLine("");
        Console.WriteLine("Salon de la fama:");
        SalondelaFama();
    }
    private void Historia() // -> Encapsulamiento
    {
        Console.WriteLine("El club Fichas FC fue fundado en el año 2018, en la ciudad de El Progreso.");
        Console.WriteLine("Su fundador, director tecnico, y dueno del club es el ex jugador del CD Faz de El Salvador, Cristian Chavez.");
        Console.WriteLine("Inicio como equipo de Liga Intermedia y actualmente compite el la Liga Mayor de su cuidad.");
    }
    private void SalondelaFama() // -> Encapsulamiento
    {
        Console.WriteLine("Campeon de Liga Intermedia en el anio 2019");
    }
}