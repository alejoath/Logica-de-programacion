using System;

namespace parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJugadores, minimo = 0, maximo = 0, intentos = 0, numeroAleatorio;
            bool haGanado = false;
            string respuesta;

            Console.WriteLine("Bienvenido al juego Adivina el número!");
            Console.WriteLine("¿Cuántos jugadores participarán? (Entre 2 y 4): ");
            numJugadores = int.Parse(Console.ReadLine());

            switch (numJugadores)
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
                    Console.WriteLine("Número de jugadores no válido. Elige entre 2 y 4.");
                    return;
            }

            Random random = new Random();
            numeroAleatorio = random.Next(minimo, maximo + 1);

            while (!haGanado)
            {
                Console.Write($"Jugador {intentos % numJugadores + 1}, ingresa tu número: ");
                int numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado < numeroAleatorio)
                {
                    Console.WriteLine("MAYOR");
                }
                else if (numeroIngresado > numeroAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    haGanado = true;
                }

                intentos++;
            }

        }
    }
}
