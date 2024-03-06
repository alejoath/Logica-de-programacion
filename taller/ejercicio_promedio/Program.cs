using System;

namespace ejercicio_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida al usuario que ingrese 3 notas
            //las promedie e indique si el estudiante aprobó o reprobó

            double Nota1 = 0, Nota2 = 0, Nota3 = 0;

            //Solicitar datos

            Console.WriteLine("Por favor ingrese la Nota1: ");
            Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la Nota2: ");
            Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la Nota3: ");
            Nota3 = double.Parse(Console.ReadLine());

            //Suma de las notas 

            double promedio = (Nota1 + Nota2 + Nota3) / 3;
            Console.WriteLine($"El promedio de las notas es: {promedio:F2}");

            if (promedio >= 3)
            {
                Console.WriteLine("¡Ganó! :D");
            }
            else
            {
                Console.WriteLine("Perdió :(");
            }

        }
    }
}
