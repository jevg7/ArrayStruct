using System;

struct Direccion
{
    public string Calle;
    public string Ciudad;
    public string CodigoPostal;

    // Constructor para inicializar los valores de Direccion
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

    // Constructor para inicializar los valores de Empleado
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
        // Solicitar al usuario los datos del empleado
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombre = Console.ReadLine();

        // Solicitar al usuario los datos de la dirección
        Console.WriteLine("Ingrese la calle:");
        string calle = Console.ReadLine();

        Console.WriteLine("Ingrese la ciudad:");
        string ciudad = Console.ReadLine();

        Console.WriteLine("Ingrese el código postal:");
        string codigoPostal = Console.ReadLine();

        // Crear una instancia de Direccion con los datos ingresados
        Direccion direccion = new Direccion(calle, ciudad, codigoPostal);

        // Crear una instancia de Empleado con los datos ingresados
        Empleado empleado = new Empleado(nombre, direccion);

        // Mostrar la información completa del empleado
        Console.WriteLine("\nInformación del empleado:");
        Console.WriteLine($"Nombre: {empleado.Nombre}");
        Console.WriteLine($"Dirección: {empleado.DireccionEmpleado.Calle}, {empleado.DireccionEmpleado.Ciudad}, {empleado.DireccionEmpleado.CodigoPostal}");
    }
}
