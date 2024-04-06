using System;

namespace parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJugadores, minimo = 0, maximo = 0, intentos = 0, numAleatorio, numIngresado;
            bool adivinoelnum = false;
            string respuesta;

            Console.WriteLine("BIENVENIDOS AL JUEGO: ¡Adivina el número!");
            Console.Write("¿Cuántos jugadores participarán? (Entre 2 y 4): ");
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
            numAleatorio = random.Next(minimo, maximo + 1);

            while (!adivinoelnum)
            {
                Console.Write($"Jugador {intentos % numJugadores + 1}, ingresa tu número: ");
                numIngresado = int.Parse(Console.ReadLine());

                if (numIngresado < numAleatorio) Console.WriteLine("MAYOR");
                else if (numIngresado > numAleatorio) Console.WriteLine("MENOR");
                else
                {
                    Console.WriteLine("¡GANASTE :)!");
                    adivinoelnum = true;
                }

                intentos++;
            }
            Console.WriteLine("¿Quieren jugar otro tirito? (si o no): ");
            respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "si")
            {
                Console.Clear();
                Main(args);
            }
            else Console.WriteLine("¡Vuelve a jugar pronto!");
   
        }
    }
}
