using System;

namespace parcial1_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de constantes
            const double velocidadTren1 = 80, velocidadTren2 = 100;

            // declaracion de variables
            double tiempoEncuentro = 1.0, distanciaRecorridaTren1 = velocidadTren1 * tiempoEncuentro;
            double distanciaTotal = distanciaRecorridaTren1, tiempoTotal = tiempoEncuentro + 1.0;

            // calculo 
            int horas = (int)tiempoTotal;
            int minutos = (int)((tiempoTotal - horas) * 60);

           







        }
    }
}
