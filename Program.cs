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
            int i = 0, j = 0, costoDia = 0, vehicprod = 0, vehicTot = 0, cantMay = 0, cantMen = 100;
            float sum = 0.0f, prom = 1.0f;

            int[][] CostoDiario = new int[5][];


            for (i = 0; i < CostoDiario.Length; i++)
            {
                Console.WriteLine("Cantidad de vehiculos producidos en el dia {0} ", i);
                vehicprod = Convert.ToInt32(Console.ReadLine());
                CostoDiario[i] = new int[vehicprod];
                vehicTot += vehicprod;
                for (j = 0; j < CostoDiario[i].Length; j++)
                {
                    Console.WriteLine("Costo del vehiculo {1} producido en el dia {0} ", i, j);
                    costoDia = Convert.ToInt32(Console.ReadLine());
                    CostoDiario[i][j] = costoDia;
                    sum += costoDia;
                   
                }
                Console.Clear();
            }
            Console.WriteLine("Mostrando tabla");
            for (i = 0; i < CostoDiario.Length; i++)
            {
                for (j = 0; j < CostoDiario[i].Length; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(CostoDiario[i][j]+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Suma es {0} y vehicTot es {1} ", sum, vehicTot);
            prom = sum / vehicTot;

            Console.WriteLine("El promedio de costos es {0} ", prom);
            
            for (i = 0; i < CostoDiario.Length; i++)
            {
                for (j = 0; j < CostoDiario[i].Length; j++)
                {
                    if (CostoDiario[i][j] < cantMen)
                    {
                        cantMen = CostoDiario[i][j];
                    }
                }

            }
            for (i = 0; i < CostoDiario.Length; i++)
            {
                for (j = 0; j < CostoDiario[i].Length; j++)
                {
                    if (CostoDiario[i][j] > cantMay)
                    {
                        cantMay = CostoDiario[i][j];
                    }
                }

            }
            Console.WriteLine("La menor costo es {0} ", cantMen);
            Console.WriteLine("La mayor costo es {0} ", cantMay);
            Console.ReadKey();
        }

    }
}
