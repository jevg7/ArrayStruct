using System;

struct Rectangulo
{
    public double Ancho;
    public double Altura;

    // Constructor para inicializar los valores del struct
    public Rectangulo(double ancho, double altura)
    {
        Ancho = ancho;
        Altura = altura;
    }

    // Método para calcular el área del rectángulo
    public double CalcularArea()
    {
        return Ancho * Altura;
    }
}

class Program
{
    static void Main()
    {
        // Solicitar al usuario la cantidad de rectángulos a ingresar
        Console.WriteLine("¿Cuántos rectángulos desea ingresar?");
        int cantidad = int.Parse(Console.ReadLine());

        // Crear un arreglo de rectángulos
        Rectangulo[] rectangulos = new Rectangulo[cantidad];

        // Ingresar los datos de los rectángulos
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nIngrese los datos del rectángulo {i + 1}:");

            Console.WriteLine("Ancho:");
            double ancho = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura:");
            double altura = double.Parse(Console.ReadLine());

            // Crear y agregar el rectángulo al arreglo
            rectangulos[i] = new Rectangulo(ancho, altura);
        }

        // Calcular y mostrar el área de cada rectángulo
        Console.WriteLine("\nÁreas de los rectángulos:");
        Console.WriteLine("-------------------------");
        for (int i = 0; i < rectangulos.Length; i++)
        {
            double area = rectangulos[i].CalcularArea();
            Console.WriteLine($"Rectángulo {i + 1}: Ancho = {rectangulos[i].Ancho}, Altura = {rectangulos[i].Altura}, Área = {area}");
        }
    }
}
