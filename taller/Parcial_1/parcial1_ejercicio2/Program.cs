using System;

namespace parcial1_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de constantes
            const double velocidadtren1 = 80, velocidadtren2 = 100;

            // declaracion de variables
            double tiempoparaencrontrarse = 1.0, distanciaRecorridaTren1 = velocidadtren1 * tiempoparaencrontrarse;
            double distanciaTotal = distanciaRecorridaTren1, tiempototal = tiempoparaencrontrarse + 1.0;

            // calculo 
            int horas = (int)tiempototal;
            int minutos = (int)((tiempototal - horas) * 60);

            //mensaje por pantalla

            Console.WriteLine($"El segundo tren alcanzará al primer tren a las {horas}:{minutos:D2} PM.");









        }
    }
}
