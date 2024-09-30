using System;

struct Coche
{
    public string Marca;
    public string Modelo;
    public int Año;

    // Constructor para inicializar los campos del struct
    public Coche(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }
}

public class Program
{
    public static void Main()
    {
        // Solicitar al usuario la cantidad de coches a ingresar
        Console.WriteLine("¿Cuántos coches desea ingresar?");
        int cantidad = int.Parse(Console.ReadLine());

        // Crear un arreglo de coches
        Coche[] coches = new Coche[cantidad];

        // Ingresar los datos de los coches
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nIngrese los datos del coche {i + 1}:");

            Console.WriteLine("Marca:");
            string marca = Console.ReadLine();

            Console.WriteLine("Modelo:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Año:");
            int año = int.Parse(Console.ReadLine());

            // Crear y agregar el coche al arreglo
            coches[i] = new Coche(marca, modelo, año);
        }

        // Mostrar la información de cada coche
        Console.WriteLine("\nInformación de los coches ingresados:");
        Console.WriteLine("-------------------------------------");
        for (int i = 0; i < coches.Length; i++)
        {
            Console.WriteLine($"Coche {i + 1}:");
            Console.WriteLine($"Marca: {coches[i].Marca}");
            Console.WriteLine($"Modelo: {coches[i].Modelo}");
            Console.WriteLine($"Año: {coches[i].Año}\n");
        }
    }
}
