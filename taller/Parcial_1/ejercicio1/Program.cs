using System;
using System.Security.Cryptography;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // declaracion de constantes
            const double sueldobase = 1380000;
            const double porcentajeComision = 0.10;
            const double objetivoventas = 1000000;

            // declaracion de variables

            double venta1, venta2, venta3, comisiontotal, salariototal, promediocomision;

            Console.WriteLine("Ingrese el valor de la primera venta: ");
            venta1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la segunda venta: ");
            venta2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la tercera venta: ");
            venta3 = double.Parse(Console.ReadLine());

            //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?

            comisiontotal = (venta1 + venta2 + venta3) * porcentajeComision;
            Console.WriteLine($"Comisión total: ${comisiontotal:N0}");

            //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?

            salariototal = sueldobase + comisiontotal;
            Console.WriteLine($"Salario total: ${salariototal:N0}");

            //¿Cuál fue la venta que le generó la mayor comisión?

            double mayor = venta1;

            if (venta2 > mayor)
                mayor = venta2;

            if (venta3 > mayor)
                mayor = venta3;

            Console.WriteLine($"La venta que mas genero comision es: {mayor :N0}");

            //¿Cuál fue el promedio de las comisiones que recibió por cada venta?

            promediocomision = comisiontotal / 3;
            Console.WriteLine($"Promedio de comisiones por ventas: ${promediocomision:N0}");

            //Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes.
            //El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas.
            //Mostrar un mensaje donde indique si ganó o no el beneficio.

            if (venta1 + venta2 + venta3 >= objetivoventas) Console.WriteLine("¡GANO BENEFICIO EXTRA POR VENTAS!");
            else Console.WriteLine("No se cumplio con el objetivo de ventas :(");


    }
    }
}
