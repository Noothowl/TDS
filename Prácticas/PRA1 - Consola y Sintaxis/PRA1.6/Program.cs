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

            Console.ReadKey();
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
