using System;
using System.Collections.Generic;

struct Producto
{
    public int ID;
    public string Nombre;
    public decimal Precio;
    public int CantidadEnStock;

    // Constructor para inicializar los valores del struct
    public Producto(int id, string nombre, decimal precio, int cantidadEnStock)
    {
        ID = id;
        Nombre = nombre;
        Precio = precio;
        CantidadEnStock = cantidadEnStock;
    }
}

class Program
{
    static void Main()
    {
        // Crear una lista para almacenar los productos
        List<Producto> productos = new List<Producto>();

        // Solicitar al usuario la cantidad de productos a ingresar
        Console.WriteLine("¿Cuántos productos desea ingresar?");
        int cantidad = int.Parse(Console.ReadLine());

        // Ingresar los datos de los productos
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nIngrese los datos del producto {i + 1}:");

            Console.WriteLine("ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Precio:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad en Stock:");
            int cantidadEnStock = int.Parse(Console.ReadLine());

            // Crear y agregar el producto a la lista
            Producto producto = new Producto(id, nombre, precio, cantidadEnStock);
            productos.Add(producto);
        }

        // Filtrar productos con existencia baja (menor que 5)
        List<Producto> productosConExistenciaBaja = productos.FindAll(p => p.CantidadEnStock < 5);

        // Mostrar productos con existencia baja
        if (productosConExistenciaBaja.Count > 0)
        {
            Console.WriteLine("\nProductos con existencia baja (Cantidad en stock < 5):");
            Console.WriteLine("---------------------------------------------------");
            foreach (var producto in productosConExistenciaBaja)
            {
                Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio:C}, Cantidad en Stock: {producto.CantidadEnStock}");
            }
        }
        else
        {
            Console.WriteLine("\nNo hay productos con existencia baja.");
        }
    }
}
