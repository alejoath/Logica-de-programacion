using System;
using System.Security.Cryptography;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            const double sueldobase = 1380000;
            const double porcentajeComision = 0.10;
            const double objetivoventas = 1000000;

            //variables

            double venta1, venta2, venta3, comisiontotal, salariototal, promediocomision;

            Console.WriteLine("Ingrese el valor de la primera venta: ");
            venta1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la segunda venta: ");
            venta2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la tercera venta: ");
            venta3 = double.Parse(Console.ReadLine());

            comisiontotal = (venta1 + venta2 + venta3) * porcentajeComision;
            Console.WriteLine($"Comisión total: ${comisiontotal:N0}");

            salariototal = sueldobase + comisiontotal;
            Console.WriteLine($"Salario total: ${salariototal:N0}");

            double mayor = venta1;

            if (venta2 > mayor)
                mayor = venta2;

            if (venta3 > mayor)
                mayor = venta3;

            Console.WriteLine($"La venta que mas genero comision es: {mayor :N0}");

            promediocomision = comisiontotal / 3;
            Console.WriteLine($"Promedio de comisiones por ventas: ${promediocomision:N0}");


            if (venta1 + venta2 + venta3 >= objetivoventas) Console.WriteLine("¡GANO BENEFICIO EXTRA POR VENTAS!");
            else Console.WriteLine("No se cumplio con el objetivo de ventas :(");


    }
    }
}
