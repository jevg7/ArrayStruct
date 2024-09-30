using System;
using System.Collections.Generic;

struct Direccion
{
    public string Calle;
    public string Ciudad;
    public string CodigoPostal;

    public Direccion(string calle, string ciudad, string codigoPostal)
    {
        Calle = calle;
        Ciudad = ciudad;
        CodigoPostal = codigoPostal;
    }
}

struct Empleado
{
    public string Nombre;
    public Direccion DireccionEmpleado;

    public Empleado(string nombre, Direccion direccion)
    {
        Nombre = nombre;
        DireccionEmpleado = direccion;
    }
}

public class Program
{
    public static void Main()
    {
        // Crear una lista para almacenar los empleados
        List<Empleado> empleados = new List<Empleado>();

        // Solicitar al usuario la cantidad de empleados a ingresar
        Console.WriteLine("¿Cuántos empleados desea ingresar?");
        int cantidad = int.Parse(Console.ReadLine());

        // Ingresar los datos de los empleados
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nIngrese los datos del empleado {i + 1}:");

            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Calle:");
            string calle = Console.ReadLine();

            Console.WriteLine("Ciudad:");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Código Postal:");
            string codigoPostal = Console.ReadLine();

            // Crear y agregar el empleado a la lista
            Direccion direccion = new Direccion(calle, ciudad, codigoPostal);
            Empleado empleado = new Empleado(nombre, direccion);
            empleados.Add(empleado);
        }

        // Solicitar la ciudad para filtrar
        Console.WriteLine("\nIngrese la ciudad para filtrar empleados:");
        string ciudadFiltro = Console.ReadLine();

        // Filtrar y mostrar los empleados que viven en la ciudad específica
        Console.WriteLine($"\nEmpleados que viven en {ciudadFiltro}:");
        foreach (var empleado in empleados)
        {
            if (empleado.DireccionEmpleado.Ciudad.Equals(ciudadFiltro, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Dirección: {empleado.DireccionEmpleado.Calle}, {empleado.DireccionEmpleado.Ciudad}, {empleado.DireccionEmpleado.CodigoPostal}");
                Console.WriteLine();
            }
        }
    }
}
