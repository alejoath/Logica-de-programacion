using System;

namespace parcial_2_ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool volver = true;
            const double BONO = 0.4; // Snake Case: Notación para constantes.

            while (volver)
            {
                decimal aporteMensual1, rendimientoMensual1, aporteTotal1 = 0, rendimientoTotal1 = 0, bonoMensual1 = 0, bonoTotal1 = 0;
                decimal aporteMensual2, rendimientoMensual2, aporteTotal2 = 0, rendimientoTotal2 = 0, bonoMensual2 = 0, bonoTotal2 = 0;
                decimal aporteTotalNeto1, aporteTotalNeto2, tasaMensual1, tasaMensual2;
                string continuar;

                // Clase random
                Random random = new Random();

                for (int mes = 1; mes <= 12; mes++)
                {
                    Console.Write($"Ingrese la cantidad que desea ahorrar en el mes {mes} para el socio 1: ");
                    aporteMensual1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write($"Ingrese la cantidad que desea ahorrar en el mes {mes} para el socio 2: ");
                    aporteMensual2 = Convert.ToDecimal(Console.ReadLine());

                    // Preguntar si el socio 1 quiere hacer un préstamo
                    Console.Write($"¿El socio 1 quiere hacer un préstamo este mes? (s/n): ");
                    string respuestaSocio1 = Console.ReadLine().ToLower();

                    // Evaluar si el préstamo supera lo ahorrado
                    if (respuestaSocio1 == "s")
                    {
                        Console.Write($"Ingrese el valor del préstamo para el socio 1: ");
                        decimal prestamoSocio1 = Convert.ToDecimal(Console.ReadLine());

                        if (prestamoSocio1 > aporteTotal1)
                        {
                            Console.WriteLine("No se aprobó la solicitud de préstamo para el socio 1. El valor del préstamo supera lo ahorrado hasta el momento.");
                            continue; // Pasar al siguiente mes
                        }
                        else
                        {
                            // Mostrar mensaje de préstamo aprobado
                            Console.WriteLine("Préstamo para el socio 1 aprobado.");
                        }
                    }

                    // Preguntar si el socio 2 quiere hacer un préstamo
                    Console.Write($"¿El socio 2 quiere hacer un préstamo este mes? (s/n): ");
                    string respuestaSocio2 = Console.ReadLine().ToLower();

                    // Evaluar si el préstamo supera lo ahorrado
                    if (respuestaSocio2 == "s")
                    {
                        Console.Write($"Ingrese el valor del préstamo para el socio 2: ");
                        decimal prestamoSocio2 = Convert.ToDecimal(Console.ReadLine());

                        if (prestamoSocio2 > aporteTotal2)
                        {
                            Console.WriteLine("No se aprobó la solicitud de préstamo para el socio 2. El valor del préstamo supera lo ahorrado hasta el momento.");
                            continue; // Pasar al siguiente mes
                        }
                        else
                        {
                            // Mostrar mensaje de préstamo aprobado
                            Console.WriteLine("Préstamo para el socio 2 aprobado.");
                        }
                    }

                    tasaMensual1 = (decimal)random.Next(1, 51) / 10;
                    rendimientoMensual1 = aporteMensual1 * (tasaMensual1 / 100);

                    tasaMensual2 = (decimal)random.Next(1, 51) / 10;
                    rendimientoMensual2 = aporteMensual2 * (tasaMensual2 / 100);

                    if (tasaMensual1 < 3.5M)
                    {
                        bonoMensual1 = aporteMensual1 * (decimal)BONO;
                        bonoTotal1 += bonoMensual1;
                        bonoMensual1 = 0;
                    }

                    if (tasaMensual2 < 3.5M)
                    {
                        bonoMensual2 = aporteMensual2 * (decimal)BONO;
                        bonoTotal2 += bonoMensual2;
                        bonoMensual2 = 0;
                    }

                    aporteTotal1 += aporteMensual1;
                    rendimientoTotal1 += rendimientoMensual1;

                    aporteTotal2 += aporteMensual2;
                    rendimientoTotal2 += rendimientoMensual2;

                    Console.Write($"MES {mes}\n" +
                                  $"Socio 1:\n" +
                                  $"Aportes: {aporteMensual1:C}\n" +
                                  $"Tasa: {tasaMensual1}%\n" +
                                  $"Rendimientos: {rendimientoMensual1:C}\n" +
                                  $"Bono: {bonoMensual1:C}\n" +
                                  $"---------------------------------------\n" +
                                  $"Socio 2:\n" +
                                  $"Aportes: {aporteMensual2:C}\n" +
                                  $"Tasa: {tasaMensual2}%\n" +
                                  $"Rendimientos: {rendimientoMensual2:C}\n" +
                                  $"Bono: {bonoMensual2:C}\n" +
                                  $"---------------------------------------\n\n");
                }

                aporteTotalNeto1 = rendimientoTotal1 + aporteTotal1 + bonoTotal1;
                aporteTotalNeto2 = rendimientoTotal2 + aporteTotal2 + bonoTotal2;

                Console.Write($"Socio 1:\n" +
                              $"Aportes totales: {aporteTotal1:C}\n" +
                              $"Rendimientos totales: {rendimientoTotal1:C}\n" +
                              $"Bonos totales: {bonoTotal1:C}\n" +
                              $"TOTAL NETO: {aporteTotalNeto1:C}\n\n" +
                              $"Socio 2:\n" +
                              $"Aportes totales: {aporteTotal2:C}\n" +
                              $"Rendimientos totales: {rendimientoTotal2:C}\n" +
                              $"Bonos totales: {bonoTotal2:C}\n" +
                              $"TOTAL NETO: {aporteTotalNeto2:C}\n\n");

                Console.WriteLine("¿Desea ingresar a la natillera para el siguiente año? (s/n)");
                continuar = Console.ReadLine().ToLower();
                if (continuar == "n") volver = false;

            }
        }
    }
}
