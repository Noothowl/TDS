using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            Random rand = new Random();


            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rand.Next(1, 100);
            }

            Console.WriteLine("\nArreglo Original");
            ImprimirArreglo(arreglo);

            Console.WriteLine("");
            Array.Sort(arreglo);

            Console.WriteLine("\nArreglo Ordenado Ascendentemente");
            ImprimirArreglo(arreglo);

            Array.Reverse(arreglo);

            Console.WriteLine("\n\nArreglo Ordenado Descendentemente");
            ImprimirArreglo(arreglo);

            Console.WriteLine("\n\nNúmero Mayor: " + arreglo.Max());
            Console.WriteLine("Número Menor: " + arreglo.Min());

            Console.WriteLine("Letras: ");
            char[] letras = new char[]{'o','O','a','i','u' };
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write(letras[i]);
            }

            Array.Sort(letras);
            Console.WriteLine();
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write(letras[i]);
            }

            Console.WriteLine("\nLetra mayor: " + letras.Max());

            Console.WriteLine("\n\nMatrices");

            int[,] matriz = new int[3, 3];  //[fila(0),columna(1)]
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    matriz[f, c] = rand.Next(1, 10);
                }
            }

            ImprimirMatriz(matriz);

            Console.ReadKey();
        }

        private static void ImprimirMatriz(int[,] matriz)
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ImprimirArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + "|");
            }
        }
    }
}
