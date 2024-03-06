using System;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un programa que pida un número y luego diga si este número es par o no
            //declaracion de variables

            int numero;

            Console.Write("Escriba el numero que quiere verificar si es par:");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
