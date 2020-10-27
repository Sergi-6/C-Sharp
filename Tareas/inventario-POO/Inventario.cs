using System;
using System.Collections.Generic;

public class Inventario
{
    public List<Producto> ListadeProductos { get; set; }
    public Inventario()
    {
        ListadeProductos = new List<Producto>();

        Producto a = new Producto("001", "iPhoneX", 0, 20000);
        Producto b = new Producto("002", "Dell", 5, 10000);
        Producto c = new Producto("003", "Monitor Samsung", 2, 2000);
        Producto d = new Producto("004", "Mouse", 100, 300);
        Producto e = new Producto("005", "Headset", 25, 500);

        ListadeProductos.Add(a);
        ListadeProductos.Add(b);
        ListadeProductos.Add(c);
        ListadeProductos.Add(d);
        ListadeProductos.Add(e);
    }

    
    public void listarProductos() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion, Existencia y Precio");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia + "|" + producto.Precio);
        }

        Console.ReadLine();
    }

    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }         
        }
    }

    public void ingresoDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }

    public void salidaDeInventario() {
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

        private void movimientoPrecio(string codigo, int precio, string tipoMovimiento) {

            foreach (var producto in ListadeProductos)
            {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                producto.Precio = producto.Precio + precio;
                } 
                else{
                      producto.Precio = producto.Precio - precio;
                    }
                }
            }
        }

        public void aumentoDePrecio() {
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

            movimientoPrecio(codigo, Int32.Parse(precio), "+");
        }

        public void disminucionDePrecio() {
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

            movimientoPrecio(codigo, Int32.Parse(precio), "-");
        }

}