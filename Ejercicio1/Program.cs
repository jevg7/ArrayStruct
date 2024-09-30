using System;

public class Estudiante
{
    // Definición de los campos
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public float Promedio { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Crear una instancia de Estudiante
        Estudiante estudiante = new Estudiante();

        // Asignar valores a los campos
        Console.Write("Ingresa el nombre del estudiante: ");
        estudiante.Nombre = Console.ReadLine();

        Console.Write("Ingresa la edad del estudiante: ");
        estudiante.Edad = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el promedio del estudiante: ");
        estudiante.Promedio = float.Parse(Console.ReadLine());

        // Mostrar la información en la consola
        Console.WriteLine("\nInformación del Estudiante:");
        Console.WriteLine($"Nombre: {estudiante.Nombre}");
        Console.WriteLine($"Edad: {estudiante.Edad}");
        Console.WriteLine($"Promedio: {estudiante.Promedio:F2}");
    }
}
