using System;

struct CuentaBancaria
{
    public string NumeroDeCuenta;
    public string NombreTitular;
    public decimal Saldo;

    // Constructor para inicializar los campos del struct
    public CuentaBancaria(string numeroDeCuenta, string nombreTitular, decimal saldo)
    {
        NumeroDeCuenta = numeroDeCuenta;
        NombreTitular = nombreTitular;
        Saldo = saldo;
    }
}

public class Program
{
    public static void Main()
    {
        // Solicitar al usuario la cantidad de cuentas a ingresar
        Console.WriteLine("¿Cuántas cuentas bancarias desea ingresar?");
        int cantidad = int.Parse(Console.ReadLine());

        // Crear un arreglo de cuentas bancarias
        CuentaBancaria[] cuentas = new CuentaBancaria[cantidad];

        // Ingresar los datos de las cuentas bancarias
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nIngrese los datos de la cuenta {i + 1}:");

            Console.WriteLine("Número de Cuenta:");
            string numeroDeCuenta = Console.ReadLine();

            Console.WriteLine("Nombre del Titular:");
            string nombreTitular = Console.ReadLine();

            Console.WriteLine("Saldo:");
            decimal saldo = decimal.Parse(Console.ReadLine());

            // Crear y agregar la cuenta bancaria al arreglo
            cuentas[i] = new CuentaBancaria(numeroDeCuenta, nombreTitular, saldo);
        }

        // Mostrar la información de cada cuenta bancaria
        Console.WriteLine("\nInformación de las cuentas bancarias:");
        Console.WriteLine("-------------------------------------");
        for (int i = 0; i < cuentas.Length; i++)
        {
            Console.WriteLine($"Cuenta {i + 1}:");
            Console.WriteLine($"Número de Cuenta: {cuentas[i].NumeroDeCuenta}");
            Console.WriteLine($"Nombre del Titular: {cuentas[i].NombreTitular}");
            Console.WriteLine($"Saldo: {cuentas[i].Saldo:C}\n");
        }
    }
}
