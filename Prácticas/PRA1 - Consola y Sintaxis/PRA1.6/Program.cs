using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correcto;
            int numero;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Ingresa un numero: ");
                correcto = int.TryParse(Console.ReadLine(), out numero);

                if (!correcto)  //correcto == false
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Debes ingresar un número entero");
                }
            } while (!correcto);

            Console.Write("Pares: ");
            ImprimirPares(numero);
            Console.Write("\nImpares: ");
            ImprimirImpares(numero);
            Console.Write("\nPrimos: ");
            ImprimirPrimos(numero);

            Console.ReadKey();
        }

        private static void ImprimirPrimos(int numero)
        {
            int x = 1,i=0;
            bool esPrimo;
           do{
                esPrimo = true;
                for (int j = 2; j < x-1; j++)
                {
                    if (x%j == 0)
                    {
                        esPrimo = false;
                    }
                }

                if (esPrimo)
                {
                    Console.Write(x+" ");
                    i++;
                }
                x++;

            }while(i<numero);
        }

        private static void ImprimirImpares(int numero)
        {
            int x = 1;
            for (int i = 0; i < numero; i++)
            {
                Console.Write(x + " ");
                x = x + 2;
            }
        }

        private static void ImprimirPares(int numero)
        {
            int x = 0;
            for (int i = 0; i < numero; i++)
            {
                Console.Write(x + " ");
                x = x + 2;
            }
        }
    }
}
