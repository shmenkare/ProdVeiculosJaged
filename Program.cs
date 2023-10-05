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

            Mostartabla(CostoDiario);
            
            Console.WriteLine("Suma es {0} y vehicTot es {1} ", sum, vehicTot);
            
            prom = Promedio(sum, vehicTot);
            Console.WriteLine("El promedio de costos es {0} ", prom);

            cantMen = Menor(CostoDiario, cantMen);
            cantMay = Mayor(CostoDiario, cantMay);

            Console.WriteLine("La menor costo es {0} ", cantMen);
            Console.WriteLine("La mayor costo es {0} ", cantMay);
            
            Console.ReadKey();
        }
        static void Mostartabla(int [][] Array) 
        {
            int i = 0, j = 0;
            Console.WriteLine("Mostrando tabla");
            for (i = 0; i < Array.Length; i++)
            {
                for (j = 0; j < Array[i].Length; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(Array[i][j] + " ");

                }
                Console.WriteLine();
            }
        }
        static float Promedio(float a, float b) 
        {
            float res = a / b;
            return res;
        }
        static int Menor(int[][] Array, int valor) 
        {
            int i = 0, j = 0;
            for (i = 0; i < Array.Length; i++)
            {
                for (j = 0; j < Array[i].Length; j++)
                {
                    if (Array[i][j] < valor)
                    {
                        valor = Array[i][j];
                    }
                }
            }
            return valor;
        }
        static int Mayor(int[][] Array, int valor)
        {
            int i = 0, j = 0;
            for (i = 0; i < Array.Length; i++)
            {
                for (j = 0; j < Array[i].Length; j++)
                {
                    if (Array[i][j] > valor)
                    {
                        valor = Array[i][j];
                    }
                }
            }
            return valor;
        }


    }
}
