using System;

namespace parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables

            int numerodejugadores, maximo = 0, minimo = 0, numeroAleatorio;

            Console.WriteLine("BIENVENIDIOS AL JUEGO: ¡Adivina el numero!");

            Console.Write("Ingrese la cantidad de jugadores entre (minimo 2 y maximo 4): ");
            numerodejugadores = int.Parse(Console.ReadLine());
            
            switch (numerodejugadores)
            {
                case 2:
                    maximo = 50;
                    break;
                case 3:
                    maximo = 100;
                    break;
                case 4:
                    maximo = 200;
                    break;
                default:
                    Console.WriteLine("Cantidad de jugadores no válida. El juego se cerrará.");
                    return;
            }

            // Generar un número aleatorio
            Random random = new Random();
            numeroAleatorio = random.Next(minimo, maximo + 1);







        }
    }
}
