// Program.cs
// Funcionalidad 1: Gestión de productos
// Rama: feature/productos

using System;
using System.Collections.Generic;

class Producto
{
    public string Nombre;
    public decimal Precio;

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class Program
{
    static List<Producto> productos = new List<Producto>
    {
        new Producto("Mouse", 50000),
        new Producto("Teclado", 80000),
        new Producto("Audífonos", 60000)
    };

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n=== MINI TIENDA ===");
            Console.WriteLine("1. Ver productos");
            Console.WriteLine("2. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarProductos();
                    break;
                case "2":
                    salir = true;
                    Console.WriteLine("¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void MostrarProductos()
    {
        Console.WriteLine("\n=== PRODUCTOS ===");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i].Nombre} ${productos[i].Precio:N0}");
        }
    }
}