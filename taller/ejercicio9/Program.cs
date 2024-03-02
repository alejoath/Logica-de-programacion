using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados

            var lista = new List<double>();

            Console.WriteLine("Ingrese el primer numero: ");
            lista.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Ingrese el segundo numero: ");
            lista.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Ingrese el tercer numero: ");
            lista.Add(double.Parse(Console.ReadLine()));

            var numeroMayor = lista.Max();

            Console.WriteLine("El numero mayor es: " + numeroMayor);

        }
    }
}
