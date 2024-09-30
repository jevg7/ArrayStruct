using System;

struct Producto
{
    public int ID;
    public string Nombre;
    public decimal Precio;

    // Constructor para inicializar los valores del struct
    public Producto(int id, string nombre, decimal precio)
    {
        ID = id;
        Nombre = nombre;
        Precio = precio;
    }
}

    public class Program
{
     public static void Main()
    {
        // Crear e inicializar un arreglo de productos
        Producto[] productos = new Producto[5]
        {
            new Producto(1, "Manzana", 0.99m),
            new Producto(2, "Pan", 1.49m),
            new Producto(3, "Leche", 2.49m),
            new Producto(4, "Café", 3.99m),
            new Producto(5, "Queso", 4.59m)
        };

        decimal precioTotal = 0;

        // Mostrar detalles de todos los productos y calcular el precio total
        foreach (var producto in productos)
        {
            Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio:C}");
            precioTotal += producto.Precio;
        }

        // Mostrar el precio total
        Console.WriteLine($"\nPrecio total de todos los productos: {precioTotal:C}");
    }
}
