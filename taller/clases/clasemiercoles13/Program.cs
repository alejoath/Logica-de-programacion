using System;

namespace clasemiercoles13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un algoritmo que pida N números por pantalla,
            //cuando el usuario ingrese un número negativo,
            //el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó
            //hasta antes de ingresarse el número negativo.

            int num, contador = 0;
            bool validador = true;

            //creacion del ciclo

            while (validador)
            {

                Console.WriteLine("ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num < 0) validador = false;
                else contador = contador + 1;

            }
            Console.WriteLine(String.Format("El total de numero positivos ingresados es de: {0}", contador));



        }
    }
}
