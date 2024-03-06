using System;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cantidadPositivos = 0;
            double numero;

            Console.WriteLine("Ingresa números:");

            do
            {
                Console.Write("Número: ");
                numero = double.Parse(Console.ReadLine());

                if (numero > 0) cantidadPositivos++;
            } while (numero >= 0); Console.WriteLine($"Cantidad de números positivos ingresados: {cantidadPositivos}");
        }
    }
    
}
