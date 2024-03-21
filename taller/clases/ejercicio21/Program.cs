using System;
using System.IO.Pipes;
using System.Reflection.PortableExecutable;

namespace ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string evaluarPaciente = "si";

            Console.WriteLine("Calculadora de IMC");

            while (evaluarPaciente == "si") 
            {
                double peso, altura;

                Console.Write("Ingrese el peso del paciente en kg: ");
                peso = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del paciente en metros: ");
                altura = double.Parse(Console.ReadLine());

                double imc = peso / Math.Pow(altura, 2);

                string categoria = null;

                if (imc < 18.5) categoria = "Peso insuficiente";
                if (imc >= 18.5 &&  imc <= 24.9) categoria = "Peso saludable";
                if (imc >= 25.0 && imc <= 29.9) categoria = "Sobre peso";
                if (imc >= 29.9) categoria = "Obesidad";

                Console.WriteLine($"El IMC del paciente es {imc:F2}. Categoría: {categoria}");

                Console.WriteLine("¿Quiere consultar el imc de un nuevo pasiente? Responder si o no");
                evaluarPaciente = Console.ReadLine(); 
            }



        }
    }
}
