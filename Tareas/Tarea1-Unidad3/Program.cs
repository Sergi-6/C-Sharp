using System;

namespace Tarea1_Unidad3
{
    class Program
    {
        static void Main(string[] args)
        {
          
        Console.WriteLine("Equipo de Futbol Fichas FC");
        Console.WriteLine("__________________________");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Direccion Tecnica");
        Console.WriteLine("=================");
        Console.WriteLine("");

        DireccionTecnica dt = new DireccionTecnica();
        dt.Nombre = "Cristian Chavez";
        dt.Edad = 30;
        dt.Apodo = "Ficha";
        dt.Telefono = "9721-2312";
        dt.Puesto = "Director Tecnico";
        Console.WriteLine("Nombre: " + dt.Nombre);
        Console.WriteLine("Edad: " + dt.Edad);
        Console.WriteLine("Apodo: " + dt.Apodo);
        Console.WriteLine("Telefono: " + dt.Telefono);
        Console.WriteLine("Puesto: " + dt.Puesto);
        dt.PerfilDT();
        Console.WriteLine("");


        Console.WriteLine("Jugadores");
        Console.WriteLine("=========");
        Console.WriteLine("");

        Jugador j = new Jugador();
        j.Nombre = "Carlos Avila";
        j.Edad = 21;
        j.Dorsal = 12;
        j.Posicion = "Lateral derecho";
        j.Apodo = "Marcelo";
        j.Estatura = 1.60;
        j.Peso = 60;
        Console.WriteLine("Nombre: " + j.Nombre);
        Console.WriteLine("Edad: " + j.Edad);
        Console.WriteLine("Dorsal: " + j.Dorsal);
        Console.WriteLine("Posicion: " + j.Posicion);
        Console.WriteLine("Apodo: " + j.Apodo);
        Console.WriteLine("Estatura: " + j.Estatura);
        Console.WriteLine("Peso: " + j.Peso);
        j.Disponible();
        Console.WriteLine("");

        Jugador j1 = new Jugador();
        j1.Nombre = "Jesus Perdomo";
        j1.Edad = 23;
        j1.Dorsal = 9;
        j1.Posicion = "Delantero centro";
        j1.Apodo = "Chungo";
        j1.Estatura = 1.82;
        j1.Peso = 74;
        Console.WriteLine("Nombre: " + j1.Nombre);
        Console.WriteLine("Edad: " + j1.Edad );
        Console.WriteLine("Dorsal: " + j1.Dorsal);
        Console.WriteLine("Posicion: " + j1.Posicion);
        Console.WriteLine("Apodo: " + j1.Apodo);
        Console.WriteLine("Estatura: " + j1.Estatura);
        Console.WriteLine("Peso: " + j1.Peso + "Kg");
        j1.Sansion();
        Console.WriteLine("");

        Jugador j2 = new Jugador();
        j2.Nombre = "Brayan Lopez";
        j2.Edad = 19;
        j2.Dorsal = 10;
        j2.Posicion = "Volante central";
        j2.Apodo = "Pichi";
        j2.Estatura = 1.62;
        j2.Peso = 67;
        Console.WriteLine("Nombre: " + j2.Nombre);
        Console.WriteLine("Edad: " + j2.Edad);
        Console.WriteLine("Dorsal: " + j2.Dorsal);
        Console.WriteLine("Posicion: " + j2.Posicion);
        Console.WriteLine("Apodo: " + j2.Apodo);
        Console.WriteLine("Estatura: " + j2.Estatura);
        Console.WriteLine("Peso: " + j2.Peso + "Kg");
        j2.Lesion();
        Console.WriteLine("");

        Console.WriteLine("Directivos");
        Console.WriteLine("=========");
        Console.WriteLine("");
        Directivo d = new Directivo();
        d.Nombre = "Cristian Chavez";
        d.Cargo = "Presidente";
        d.Telefono = "9721-2312";
        Console.WriteLine("Nombre: " + d.Nombre);
        Console.WriteLine("Cargo: " + d.Cargo);
        Console.WriteLine("Telefono: " + d.Telefono);
        Console.WriteLine("");

        Directivo d1 = new Directivo();




        Console.WriteLine("Informacion del Club");
        Console.WriteLine("====================");

        Club c = new Club();
        c.Informacion();




        }
    }
}
