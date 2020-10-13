using System;

namespace inventario
{
    class Program
    {
        static string[,] productos = new string[5,4]
        {
            { "001", "iPhone X", "0", "20000.00", },
            { "002", "Laptop Dell", "5", "10000.00" },
            { "003", "Monitor Samsung", "2", "2000.00" },
            { "004", "Mouse", "100", "300.00" },
            { "005", "HeadSet", "25", "500.00" }
        };

        static void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion, Existencia y Precio");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i, 0] + " | " + productos[i, 1] + " | " + productos[i, 2] + " | " + productos[i, 3]);
            }

            Console.ReadLine();

        }  

        static void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
            for (int i = 0; i < 5; i++)
            {
                if (productos[i, 0] == codigo) {
                    if (tipoMovimiento == "+") {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                    } else {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
                }
            }
        }

        static void ingresoDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.WriteLine("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        static void salidaDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Salida de Productos del Inventario");
            Console.WriteLine("**********************************");
            Console.WriteLine("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }

        static void movimientoPrecio(string codigo, double precio, string tipoMovimiento) {
            for (int i = 0; i < 5; i++)
            {
                if (productos[i, 0] == codigo) {
                    if (tipoMovimiento == "+") {
                        productos[i, 3] = (Convert.ToDouble(productos[i, 3]) + precio).ToString();
                    } else {
                        productos[i, 3] = (Convert.ToDouble(productos[i, 3]) - precio).ToString();
                    }
                }
            }
        }

        static void aumentoDePrecio() {
            string codigo = "";
            string precio = "";

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Aumento en el precio del Producto");
            Console.WriteLine("**********************************");
            Console.WriteLine("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese cuanto ha subido el precio del producto: ");
            precio = Console.ReadLine();
            Console.WriteLine();

            movimientoPrecio(codigo, Convert.ToDouble(precio), "+");
        }

        static void disminucionDePrecio() {
            string codigo = "";
            string precio = "";

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Aumento en el precio del Producto");
            Console.WriteLine("**********************************");
            Console.WriteLine("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese cuanto ha disminuido el precio del producto: ");
            precio = Console.ReadLine();
            Console.WriteLine();

            movimientoPrecio(codigo, Convert.ToDouble(precio), "-");
        }

        static void Main(string[] args)
        {
            string opcion="";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de inventario");
                Console.WriteLine("3 - Salida de inventario");
                Console.WriteLine("4 - Aumento en el precio del producto");
                Console.WriteLine("5 - Descenso en el precio del producto");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        listarProductos();
                        break;

                    case "2":
                        ingresoDeInventario();
                        break;
                    
                    case "3":
                        salidaDeInventario();
                        break;
                    
                    case "4":
                        aumentoDePrecio();
                        break;
                    
                    case "5":
                        disminucionDePrecio();
                        break;

                    default:
                        break;
                }

                

                if (opcion == "0")
                {
                    break;
                }

            }
            
            
        }
    }
}
