using System;

namespace distanciaentredospuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables

            double x1 = 0, y1 = 0, x2 = 0, y2 = 0, distancia;

            //Solicitar datos
            Console.Write("Por favor ingrese valor para x1:");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Por favor ingrese valor para y1:");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Por favor ingrese valor para x2:");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Por favor ingrese valor para y2:");
            y2 = double.Parse(Console.ReadLine());

            //Proceso
            distancia = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            //Salida
            Console.WriteLine("La distancia entre los pares ordenados(" + x1 + "," + y1 + ") y (" + x2 + "," + y2 + ") es = " + distancia);
        }
    }
}
