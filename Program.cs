using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ProdVeiculosJaged
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, ventaDia = 0, totDias = 20, cantMay = 0, cantMen = 100;
            float sum = 1.0f, prom = 1.0f;

            int[,] VentaSemanal = new int[4, 5];

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Cantidad de vehiculos producidos en el dia {0}{1}", i, j);
                    ventaDia = Convert.ToInt32(Console.ReadLine());
                    VentaSemanal[i, j] = ventaDia;
                    sum += ventaDia;
                    Console.Clear();
                }
            }
            Console.WriteLine("Mostrando tabla");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(VentaSemanal[i, j]);

                }
                Console.WriteLine();
            }
            prom = sum / totDias;

            Console.WriteLine("El promedio de ventas es {0} ", prom);
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (VentaSemanal[i, j] < cantMen)
                    {
                        cantMen = VentaSemanal[i, j];
                    }
                }

            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (VentaSemanal[i, j] > cantMay)
                    {
                        cantMay = VentaSemanal[i, j];
                    }
                }

            }
            Console.WriteLine("La menor cantidad producida es {0} ", cantMen);
            Console.WriteLine("La mayor cantidad producida es {0} ", cantMay);
            Console.ReadKey();
        }

    }
}
